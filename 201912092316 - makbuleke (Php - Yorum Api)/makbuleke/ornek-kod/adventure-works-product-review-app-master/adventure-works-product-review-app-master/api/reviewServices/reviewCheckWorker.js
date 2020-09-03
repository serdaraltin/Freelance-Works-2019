const AWS = require("aws-sdk");
const QueueService = require("/opt/services/queueService/queueService");

const lambda = new AWS.Lambda({
    region: process.env.region
});

const sqs = new QueueService(
    process.env.region
);

const badWords = ["fee", "nee", "cruul", "leent"];

function detectBadWords(review, badWords = []){
    var regex = new RegExp( badWords.join( "|" ), "i");
    return regex.test( review.replace(/[^0-9a-z]/gi,'') ); // remove  all non-alphanumeric chars first
}

exports.handler = async (event) => {
    const records = event.Records;
    for( let record of records ){
        if( !record.messageAttributes || !record.messageAttributes.ReviewID ){// malformed record
            continue
        }
        const review = {
            reviewID: parseInt( record.messageAttributes.ReviewID.stringValue ),
            review: record.body,
            email: record.messageAttributes.Reviewer.stringValue
        };

        review.status = detectBadWords(review.review, badWords) ? 'DECLINED' : 'APPROVED';

        // update DB
        const lambdaParams = {
            FunctionName: "updateReview",
            InvocationType: "RequestResponse",
            Payload: JSON.stringify(review)
        };
        const res = await lambda.invoke(lambdaParams).promise().catch(err => console.log(err) );

        const emailSqsParams = {
            MessageAttributes: {
                "Reviewer": {
                    DataType: "String",
                    StringValue: review.email
                }
            },
            MessageBody: `Your review has been ${review.status}`,
            QueueUrl: process.env.emailWorkerEndpoint
        };
        await sqs.send(emailSqsParams)
            .catch(err => console.log("enqueue error on insert email", err) );

    }

    const response = {
        statusCode: 200,
        body: "review check worker called"
    };
    return response;
};
