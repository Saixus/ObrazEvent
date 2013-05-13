define('vm',
    [
        'vm.about',
        'vm.services'
    ],
    function (about, services) {
        return {
            about: about,
            services: services
        };
    });