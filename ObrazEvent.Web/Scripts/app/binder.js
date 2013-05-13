define('binder',
    ['jquery', 'ko', 'consts', 'vm'],
    function ($, ko, consts, vm) {
        var
            ids = consts.viewIds,

            bind = function () {
                ko.applyBindings(vm.about, getView(ids.about));
                ko.applyBindings(vm.services, getView(ids.services));
            },

            getView = function (viewName) {
                alert($(viewName));
                alert($(viewName).get(0));
                return $(viewName).get(0);
            };

        return {
            bind: bind
        };
    });