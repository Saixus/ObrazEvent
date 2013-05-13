define('route-config',
    [
        'vm', 'consts', 'router'
    ],
    function (vm, consts, router) {
        var register = function () {
            
            var routeData = [
                {
                    view: consts.viewIds.about,
                    routes: [
                        {
                            isDefault: true,
                            callback: vm.about.activate,
                            route: consts.hashes.about,
                            title: 'О Компании',
                            group: '.route-top'
                        }, {
                            route: '#/',
                            title: 'adasdas',
                            callback: consts.hashes.about,
                            group: '.route-left'
                        }
                    ]
                },
                {
                    view: consts.viewIds.services,
                    routes: [
                        {
                            callback: vm.services.activate,
                            route: consts.hashes.services,
                            title: 'Услуги',
                            group: '.route-top'
                        }
                    ]
                }
            ];

            for (var i = 0; i < routeData.length; i++) {
                router.register(routeData[i]);
            }

            // Crank up the router
            router.run();
        };
        return {
            register: register
        };
    });