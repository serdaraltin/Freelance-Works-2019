const DBService = require("/opt/services/dbService/dbService");

exports.handler = async (event) => {

    const db = new DBService()
        .init(process.env.dbClient,
            process.env.dbHost,
            process.env.dbUser,
            process.env.dbPassword,
            process.env.dbDatabase,
            true
        );

    const review = event;
    console.log(review);
    const reviewID = await db
        .insertReview(review)
        .catch(
            err => {
                console.log("error while inserting review to db", err);
                // throw new Error();
            });

    return reviewID;

};
