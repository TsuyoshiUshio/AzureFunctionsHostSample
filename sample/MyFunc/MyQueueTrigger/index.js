module.exports = function (context, myQueueItem) {
    context.log('JavaScript queue trigger function processed work item', myQueueItem);
    var fs = require('fs');
    fs.writeFile('writetest.log',  myQueueItem, function(err) {
        console.log(err);
    })
    context.done();
};