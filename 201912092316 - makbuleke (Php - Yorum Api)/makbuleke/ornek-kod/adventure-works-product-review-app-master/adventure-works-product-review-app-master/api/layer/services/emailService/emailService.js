module.exports = function EmailService() {
    async function sendEmail(to, review) {
        // sending email here
        console.log( "review email has sent" );
        return {to, review};
    }

    return Object.freeze({
        sendEmail,
    });
};