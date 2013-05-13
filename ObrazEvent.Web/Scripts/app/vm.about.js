define('vm.about',
    [],
    function () {
        var activate = function (routeData, callback) {
            //refresh(callback);
            alert(1);
        };
        return {
            activate: activate
        };
    });