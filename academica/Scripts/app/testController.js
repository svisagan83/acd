﻿

//app.run(function (editableOptions) {
//    editableOptions.theme = 'bs3';
//});



//// --------------- mock $http requests ----------------------
//app.run(function ($httpBackend) {
//    $httpBackend.whenGET('/groups').respond([
//      { id: 1, text: 'user' },
//      { id: 2, text: 'customer' },
//      { id: 3, text: 'vip' },
//      { id: 4, text: 'admin' }
//    ]);

//    $httpBackend.whenPOST(/\/saveUser/).respond(function (method, url, data) {
//        data = angular.fromJson(data);
//        return [200, { status: 'ok' }];
//    });
//});