const AWS = require('aws-sdk');

module.exports = class QueueService {
    constructor(region){
        this.queue = new AWS.SQS({
            apiVersion: '2012-11-05',
            region: region,
        });
    }

    async send(params){
        const res = await this.queue.sendMessage(params).promise()
            // .catch(error => console.log(error));
        console.log("item inserted to queue with params", JSON.stringify(params));
        return res;
    }

    async receive(params){
        return await this.queue.receiveMessage(params)
            .promise()
            .catch(error => console.log(error));
    }

    async delete(params) {
        const res = await this.queue.deleteMessage(params)
            .promise()
            .catch(error => console.log(error));
        console.log("item deleted from queue with params", JSON.stringify(params));
        return res;
    }

};
