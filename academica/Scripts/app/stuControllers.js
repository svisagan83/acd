/// <reference path="../angular.js" />
var stuControllers = angular.module("stuControllers", []);
stuControllers.controller("GetStudentsList", function ($scope, $http) {
    $http.get("/api/students1/").success(function (data) {
        $scope.students = data;
    });    
});

stuControllers.controller("AddCorporate", function ($scope, $http, $location) {

    $scope.corporate = {
        CompanyName: "",
        FirstName: "",
        LastName: "svsd",
        Email: "",
        Password: "",
        PasswordConfirm: "",
        Address1: "",
        Address2: "",
        City: "",
        State: "",
        Country: "",
        PostalZip: "",
        Designation: "",
        Mobile: ""
    };

    $scope.Add = function () {

        $http.post('/api/MRCorporates', $scope.corporate, 'application/json; charset=utf-8').success(function (data, status, headers, config) {
            // when the response is available  
            $scope.corporate = {
                CompanyName: "",
                FirstName: "",
                LastName: "",
                Email: "",
                Password: "",
                PasswordConfirm: "",
                Address1: "",
                Address2: "",
                City: "",
                State: "",
                Country: "",
                PostalZip: "",
                Designation: "",
                Mobile: ""
            };
            alert("Success");
        }).error(function (data, status, headers, config) {
            // or server returns response with an error status.  
        });
    }

    //$http.get("/api/students/").success(function (data) {
    //    debugger;
    //    $scope.students = data;
    //});
});

stuControllers.controller("jobPosting", function ($scope, $http) {
    $http.get("/api/students1/").success(function (data) {
        $scope.students = data;
    });
});
stuControllers.controller("jobSummary", function ($scope, $http) {
    $http.get("/api/students1/").success(function (data) {
        $scope.students = data;
    });
});
stuControllers.controller("contact", function ($scope, $http) {
    $http.get("/api/students1/").success(function (data) {
        $scope.students = data;
    });
});
stuControllers.controller("createProfile", function ($scope, $http) {
    $http.get("/api/students1/").success(function (data) {
        $scope.students = data;
    });
});
stuControllers.controller("createRequest", function ($scope, $http) {
    $http.get("/api/students1/").success(function (data) {
        $scope.students = data;
    });
});