define('messenger',
['amplify', 'consts'],
    function (amplify, consts) {
        var
            priority = 1,

            publish = function (topic, options) {
                amplify.publish(topic, options);
            },

            subscribe = function (options) {
                amplify.subscribe(
                    options.topic,
                    options.context,
                    options.callback,
                    priority);
            };

        publish.viewModelActivated = function (options) {
            amplify.publish(consts.messages.viewModelActivated, options);
        };

        return {
            publish: publish,
            subscribe: subscribe
        };
    });
