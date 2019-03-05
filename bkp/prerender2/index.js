const express = require('express');
const app = express();
const phantom = require('phantom');
const sleep = require('sleep-promise');
app.use((req, res, next) => {
    (async function () {
        const instance = await phantom.create(
            [`--load-images=no'`]
        );
        const page = await instance.createPage();
        await page.on('onResourceRequested', (requestData) => console.log('Requesting: ', requestData.url));
        await page.on('onError', err => console.log('Error: ', err));
        const status = await page.open(req.originalUrl.slice(1));
        await sleep(5000); // wait 5 seconds to render HTML
        const content = await page.property('content');
        await instance.exit();
        // send response
        res.send(content);
    })();
});
// run app on port 3000
app.listen(3000, () => {
    console.log('Prerender listening app on port 3000!');
});