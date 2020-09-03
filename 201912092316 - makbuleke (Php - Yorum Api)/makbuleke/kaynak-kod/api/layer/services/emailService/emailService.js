module.exports = function EmailService() {
    async function sendEmail(to, review) {
        console.log( "review email has sent" );
        return {to, review};
    }

    return Object.freeze({
        sendEmail,
    });
};