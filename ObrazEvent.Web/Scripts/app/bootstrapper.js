define('bootstrapper',
    [
        'presenter', 'route-config', 'binder'
    ],
    function (presenter, routeConfig, binder) {
        var run = function () {
            
            presenter.toggleActivity(true);
            binder.bind();
            routeConfig.register();
            presenter.toggleActivity(false);
        };
        return {
            run: run
        };
    });