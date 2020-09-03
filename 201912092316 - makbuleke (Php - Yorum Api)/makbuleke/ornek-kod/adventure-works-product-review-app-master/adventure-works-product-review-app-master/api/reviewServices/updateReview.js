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
    const res = await db
        .updateReviewByID(review)
        .catch(
            err => {
                console.log("error while updating review", err);
                // throw new Error();
            });
    console.log("updated review", res);
    return res;

};


