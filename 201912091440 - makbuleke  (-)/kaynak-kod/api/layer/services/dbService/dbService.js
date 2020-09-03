const ProductReviewMapper = require('../../mapper/productReviewMapper');

module.exports = class DBService {

    constructor() {
        const instance = this.constructor.instance;
        if (instance) {
            return instance;
        }

        this.constructor.instance = this;
    }

    init(client, host, user, password, database, closeOnComplete = false){
        this.db = require('knex')({
            client: client,
            connection: {
                host : host,
                user : user,
                password : password,
                database : database
            }
        });
        this.closeOnComplete = closeOnComplete
        return this;
    }

    close(){
        this.db.destroy();
    }

    async insertReview(review){
        try{
            review.LastUpdateAt = new Date();
            review.CreatedAt = new Date();
            review.status = "PENDING";
            const reviewID = await this.db('productreview').insert(
                ProductReviewMapper()
                    .map(review)
            );
            console.log(`new revivew inserted with id ${reviewID}`);
            return reviewID[0];
        } catch (error) {
            console.log(error);
        } finally {
            this.closeOnComplete && this.db.destroy();
        }
    }

    async updateReviewByID(review){
        try{
            review.LastUpdateAt = new Date();
            const res = await this.db('productreview')
                .where({ ProductReviewID: review.reviewID })
                .update(
                    ProductReviewMapper()
                        .map(review,true)
                );
            console.log(`review with id ${review.reviewID} updated`);
            return res;
        } catch (error) {
            console.log(error);
        } finally {
            this.closeOnComplete && this.db.destroy();
        }
    }

    async getReviews(){
        try {
            return await this.db
                .select()
                .from('productreview')
        } catch (error) {
            console.log(error);
        } finally {
            this.closeOnComplete && this.db.destroy();
        }
    }

    async getReviewByID(reviewID){
        try {
            return await this.db
                .select()
                .from('productreview')
                .where("ProductReviewID","=",reviewID)
        } catch (error) {
            console.log(error);
        } finally {
            this.closeOnComplete && this.db.destroy();
        }
    }

    async getReviewByStatus(status){
        try{
            if(["PENDING", "APPROVED", "DECLINED"].includes(status))
                return await this.db
                    .select()
                    .from('productreview')
                    .where("Status","=",status)
        } catch (error) {
            console.log(error);
        } finally {
            this.closeOnComplete && this.db.destroy();
        }
    }


};

