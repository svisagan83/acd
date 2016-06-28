/// <reference path="../angular.js" />
var stuControllers = angular.module("stuControllers", []);
stuControllers.controller('CtrlSample', function ($scope, $filter, $http) {
    $scope.sampletext = "Hi this my first page.";

    $scope.statuses = [
      {value: 1, text: 'status1'},
      {value: 2, text: 'status2'},
      {value: 3, text: 'status3'},
      {value: 4, text: 'status4'}
    ]; 

    $scope.add = function () {
        alert("Hai");
    };  

});

stuControllers.controller("GetStudentsList", function ($scope, $http) {
    $http.get("/api/students1/").success(function (data) {
        $scope.students = data;
    });
});

stuControllers.controller("login", function ($scope, $http) {
    
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


stuControllers.controller('CtrlTest1', function ($scope, $filter, $http) {

    $scope.users = [
      { id: 1, name: 'awesome user1', status: 2, group: 4, groupName: 'admin' },
      { id: 2, name: 'awesome user2', status: undefined, group: 3, groupName: 'vip' },
      { id: 3, name: 'awesome user3', status: 2, group: null }
    ];

    $scope.statuses = [
      { value: 1, text: 'status1' },
      { value: 2, text: 'status2' },
      { value: 3, text: 'status3' },
      { value: 4, text: 'status4' }
    ];

    $scope.groups = [];
    //$scope.loadGroups = function () {
    //    return $scope.groups.length ? null : $http.get('/test').success(function (data) {
    //        $scope.groups = data;
    //    });
    //};

    $scope.showGroup = function (user) {
        if (user.group && $scope.groups.length) {
            var selected = $filter('filter')($scope.groups, { id: user.group });
            return selected.length ? selected[0].text : 'Not set';
        } else {
            return user.groupName || 'Not set';
        }
    };

    $scope.showStatus = function (user) {
        var selected = [];
        if (user.status) {
            selected = $filter('filter')($scope.statuses, { value: user.status });
        }
        return selected.length ? selected[0].text : 'Not set';
    };

    $scope.checkName = function (data, id) {
        if (id === 2 && data !== 'awesome') {
            return "Username 2 should be `awesome`";
        }
    };

    //$scope.saveUser = function (data, id) {
    //    //$scope.user not updated yet
    //    angular.extend(data, { id: id });
    //    return $http.post('/saveUser', data);
    //};

    // remove user
    $scope.removeUser = function (index) {
        $scope.users.splice(index, 1);
    };

    // add user
    $scope.addUser = function () {
        $scope.inserted = {
            id: $scope.users.length + 1,
            name: '',
            status: null,
            group: null
        };
        $scope.users.push($scope.inserted);
    };
});