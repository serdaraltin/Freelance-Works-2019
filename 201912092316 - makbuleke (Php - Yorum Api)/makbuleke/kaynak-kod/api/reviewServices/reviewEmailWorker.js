const EmailService = require("/opt/services/emailService/emailService");
const QueueService = require("/opt/services/queueService/queueService");
const sqs = new QueueService( process.env.region );

exports.handler = async (event) => {
    const records = event.Records;
    for( let record of records ){
        if( !record.messageAttributes || !record.messageAttributes.Reviewer ){// malformed record
            continue
        }

        console.log(record)

        const reviewer = record.messageAttributes.Reviewer.stringValue;
        const emailBody = record.body;

        const res = await EmailService().sendEmail(reviewer, emailBody);
        console.log("review email worker called", res);
    }
    return true;
};