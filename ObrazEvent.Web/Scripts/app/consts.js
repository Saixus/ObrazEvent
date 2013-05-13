
define('consts',
    ['toastr'],
    function (toastr) {
        var title = 'Образю Ивент-студия > ',
            logger = toastr, // use toastr for the logger
            messages = {
                viewModelActivated: 'viewmodel-activation'
            },
            viewIds = {
                about: '#about-view',
                services: '#services-view'
            },
            hashes = {
                about: '#/about',
                services: '#/services'
            },
            stateKeys = {
                lastView: 'state.active-hash'
            },
            toasts = {
                changesPending: 'Please save or cancel your changes before leaving the page.',
                errorSavingData: 'Data could not be saved. Please check the logs.',
                errorGettingData: 'Could not retrieve data.  Please check the logs.',
                invalidRoute: 'Cannot navigate. Invalid route',
                retreivedData: 'Data retrieved successfully',
                savedData: 'Data saved successfully'
            }
            ;
        return {
            title: title,
            viewIds: viewIds,
            hashes: hashes,
            stateKeys: stateKeys,
            window: window,
            logger: logger,
            messages: messages,
            toasts: toasts
        };
    });
