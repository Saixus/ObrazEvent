define('route-mediator',
['messenger', 'consts'],
    function (messenger, consts) {
        var
            canleaveCallback,
            self = this,

            viewModelActivated = function (options) {
                canleaveCallback = options && options.canleaveCallback;
            },

            canLeave = function () {
                // Check the active view model to see if we can leave it
                var
                    val = canleaveCallback ? canleaveCallback() : true,
                    response = { val: val, message: consts.toasts.changesPending };
                return response;
            },

            subscribeToViewModelActivations = function () {
                var context = self;
                messenger.subscribe({
                    topic: consts.messages.viewModelActivated,
                    context: context,
                    callback: viewModelActivated
                });
            },

            init = function () {
                subscribeToViewModelActivations();
            };

        init();

        return {
            canLeave: canLeave
        };
    });
