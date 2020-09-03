const fs = require('fs');

fs.readFile('./terraformOutput.json', 'utf8', (err, fileContents) => {
    if (err) {
        console.error(err)
        return
    }
    try {
        const config = {};
        const data = JSON.parse(fileContents)
        for (prop in data) {
            config[prop] = data[prop].value;
        }
        fs.writeFile("../api/serverlessConfig.json", JSON.stringify(config), function(err) {
            if(err) {
                return console.log(err);
            }

            console.log("The file was saved!");
        });

    } catch(err) {
        console.error(err)
    }
})