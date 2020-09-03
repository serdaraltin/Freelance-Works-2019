const AWS = require("aws-sdk");
const QueueService = require("/opt/services/queueService/queueService");

const lambda = new AWS.Lambda({
    region: process.env.region
});
const sqs = new QueueService(process.env.region);

async function postReview(event){
    const review = JSON.parse(event.body);
    const lambdaParams = {
        FunctionName: "insertReview",
        InvocationType: "RequestResponse",
        Payload: JSON.stringify(review)
    };
    const res = await lambda.invoke(lambdaParams ).promise().catch(err => console.log(err) );
    const sqsParams = {
        MessageAttributes: {
            "ReviewID": {
                DataType: "Number",
                StringValue: res.Payload.toString()
            },
            "Reviewer":{
                DataType: "String",
                StringValue: review.email
            }
        },
        MessageBody: review.review,
        QueueUrl: process.env.reviewCheckWorkerEndpoint
    };
    await sqs.send(sqsParams)
        .catch(err => console.log("enqueue error on insert review", err) );


    return {
        statusCode: 200,
        body: JSON.stringify({
            reviewID: res.Payload
        }),
    };

}

// TODO: add getReviewById feature
async function getReview(event){
    const lambdaParams = {
        FunctionName: "getReview",
        InvocationType: "RequestResponse",
        Payload: null
    };
    const res = await lambda.invoke(lambdaParams).promise().catch(err => console.log(err) );

    return {
        statusCode: 200,
        body: JSON.stringify({
            reviews: JSON.stringify(res.Payload)
        }),
    };
}


exports.handler = async (event) => {

    try{
        const httpMethod  = event.httpMethod;
        if( httpMethod === 'POST' ){

            return await postReview(event);

        } else if( httpMethod === 'GET' ){

            return await getReview(event);

        } else { // unsupported http method
            return {
                statusCode: 404
            };
        }
    }catch (error) {
        return {
            statusCode: 500,
            body: ""
        };
    }

};