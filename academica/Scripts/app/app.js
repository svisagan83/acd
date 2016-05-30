/// <reference path="../angular.js" />
var module = angular.module("StudentApp", ["ngRoute", "stuControllers", "stuResources", "UserValidation"]);

module.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/home', {
        templateUrl: 'template/home.html',
        controller: 'GetStudentsList'
        })
        .when('/login', {
            templateUrl: 'template/login.html',
            controller: 'login'
        })
        .when('/signup', {
            templateUrl: 'template/signup.html',
            controller: 'AddCorporate'
        })
        .when('/thenth', {
            templateUrl: 'template/thenth.html',
            controller: 'thenth'
        })
        .when('/contact', {
            templateUrl: 'template/contact.html',
            controller: 'contact'
        })
        .when('/createProfile', {
            templateUrl: 'template/createProfile.html',
            controller: 'createProfile'
        })
        .when('/createRequest', {
            templateUrl: 'template/createRequest.html',
            controller: 'createRequest'
        })
        .when('/custSearch', {
            templateUrl: 'template/custSearch.html',
            controller: 'custSearch'
        })
        .when('/jobPosting', {
            templateUrl: 'template/jobPosting.html',
            controller: 'jobPosting'
        })
        .when('/jobSummary', {
            templateUrl: 'template/jobSummary.html',
            controller: 'jobSummary'
        })
        .when('/preCriteria', {
            templateUrl: 'template/preCriteria.html',
            controller: 'preCriteria'
        })
        .when('/preSearch', {
            templateUrl: 'template/preSearch.html',
            controller: 'preSearch'
        })        
        .otherwise({
        redirectTo: '/home'
    });
}]);

angular.module('UserValidation', [])
    .directive('validPasswordC', function () {
        return {
            require: 'ngModel',
            link: function (scope, elm, attrs, ctrl) {
                ctrl.$parsers.unshift(function (viewValue, $scope) {
                    var noMatch = viewValue != scope.myForm.password.$viewValue
                    ctrl.$setValidity('noMatch', !noMatch)
                })
            }
        }
    })
    .directive('pwCheck', [function () {
        return {
            require: 'ngModel',
            link: function (scope, elem, attrs, ctrl) {
                var firstPassword = '#' + attrs.pwCheck;
                elem.add(firstPassword).on('keyup', function () {
                    scope.$apply(function () {
                        // console.info(elem.val() === $(firstPassword).val());
                        ctrl.$setValidity('pwmatch', elem.val() === $(firstPassword).val());
                    });
                });
            }
        }
    }]);