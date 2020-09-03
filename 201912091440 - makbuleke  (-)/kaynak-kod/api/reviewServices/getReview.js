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

    const res = await db
        .getReviews()
        .catch(
            err => {
                console.log("error while getting review from db", err);
            });
    return res;

};
