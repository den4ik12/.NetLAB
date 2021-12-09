﻿var apiBaseUrl = "http://localhost:61043/api/";
var carUrl = apiBaseUrl + "Auto/";
console.log(carUrl);
function reloadUserList() {
	var usersList = $("#CarList");
	if (usersList.length) { //Есть элемент для списка пользователей - значит мы на главной странице - можно загрузить список
		$.ajax({
			url: carUrl,
			dataType: "json",
			data: null,
			type: "GET",
			success: function (data) {
				var itemsCount = data.length;
				usersList.html("");
				var html = "<table>";
				for (var i = 0; i < itemsCount; i++) {
					var item = data[i];
					var userId = item.AutoId;
					var number = item.Number;
					var firstName = item.uName;
					var secondName = item.LastName;
					var producerID = item.ProducerId;
					html += "<tr><td>" + number + "</td><td>" + firstName + "</td><td>" + secondName + "</td>";
					html += "<td><a href='Edit?id=" + userId + "'>Редактировать</a>&nbsp;<a href='#' class='delete_user' data-id='" + userId + "'>Удалить</a></td></tr>";
				}
				html += "</table>";
				usersList.html(html);
			}
		});
	}
}
$(function () {
	reloadUserList();
	var userInfo = $("#UserInfo");
	if (userInfo.length) { //Есть элемент для информации о пользователе -  загрузить информацию о нём
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");
		if (id != null) {
			$.ajax({
				url: usersUrl + id + "/",
				dataType: "json",
				data: null,
				type: "GET",
				success: function (data) {
					var userId = data.UserId;
					var firstName = data.FirstName;
					var secondName = data.SecondName;
					var lastName = data.LastName;
					$("#LastName").val(lastName);
					$("#FirstName").val(firstName);
					$("#SecondName").val(secondName);
				}
			});
			userInfo.after("<input type='button' id='EditUser' value='Сохранить'/>");
		}
		else {
			userInfo.after("<input type='button' id='CreateUser' value='Создать'/>");
		}
	};
	$(document).on("click", "a.delete_user", function () {
		var id = $(this).attr("data-id");
		if (id != null) {
			$.ajax({
				url: usersUrl + id + "/",
				dataType: "json",
				data: null,
				type: "DELETE",
				success: function (data) {
					reloadUserList();
				}
			});
		}
	});
	$(document).on("click", "#CreateUser", function () {
		var userData = {
			LastName: $("#LastName").val(),
			FirstName: $("#FirstName").val(),
			SecondName: $("#SecondName").val()
		};
		$.ajax({
			url: usersUrl,
			dataType: "json",
			data: userData,
			type: "POST",
			success: function () {
				window.location.href = "../Users/index.html";
			}
		});
	});
	$(document).on("click", "#EditUser", function () {
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");
		if (id != null) {
			var userData = {
				UserId: id,
				LastName: $("#LastName").val(),
				FirstName: $("#FirstName").val(),
				SecondName: $("#SecondName").val()
			};
			$.ajax({
				url: usersUrl + id + "/",
				dataType: "json",
				data: userData,
				type: "PUT",
				success: function () {
					window.location.href = "../Users/index.html";

				}
			});
		}
	});
})
