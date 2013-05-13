define('store',
    ['jquery', 'amplify', 'consts'],
    function ($, amplify, consts) {
        //alert(32132);
        var
            expires = { expires: consts.storeExpirationMs },

            clear = function (key) {
                return amplify.store(key, null);
            },

            fetch = function (key) {
                return 0; //return amplify.store(key);
            },

            save = function (key, value) {
                amplify.store(key, value, expires);
            };

        return {
            clear: clear,
            fetch: fetch,
            save: save
        };
    });