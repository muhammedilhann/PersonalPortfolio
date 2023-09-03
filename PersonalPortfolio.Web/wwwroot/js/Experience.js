//#region DataTable
function GetExperienceData() {
    $.ajax({
        type: "GET",
        url: "/Admin/Experience/GetExperienceData",
        datatype: "json",
        dataSrc: "",
        success: function (response) {
            $('#ExperienceTable').DataTable({
                dom: 'Bfrtip',
                serverSide: false,
                processing: false,
                stateSave: true,
                responsive: false,
                destroy: true,
                lengthMenu: [
                    [10, 25, 50, -1],
                    [10, 25, 50, 'All'],
                ],

                data: response.data,
                columns: [
                    { "data": 'Id' },
                    { "data": 'Title' },
                    { "data": 'Description' },
                    {
                        "data": 'StartDate', "render": function (data, type, row, meta) {
                            return formatDate(data);
                        }
                    },
                    {
                        "data": 'FinishDate', "render": function (data, type, row, meta) {
                            return formatDate(data);
                        }
                    },

                    {
                        "render": function (data, type, full, meta) {
                            var result = "";
                            result += "<a class='btn btn-sm btn-primary' title='Update' onclick=UpdateExperience('" + full.Id + "');><i class='fas fa-edit'></i></button>";
                            result += "<a class='btn btn-sm btn-danger ml-2' title='Delete' onclick=DeleteExperience('" + full.Id + "');><i class='fas fa-trash'></i></button>";
                            return result;
                        }
                    }
                ],

            });
            $("#searchFilter").keyup(function () {
                $("#ExperienceTable").DataTable().search($("#searchFilter").val()).draw();
            });
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}

function formatDate(dateVal) {
    var date = new Date(dateVal);
    var day = String(date.getDate()).padStart(2, '0');
    var month = String(date.getMonth() + 1).padStart(2, '0');
    var year = date.getFullYear();
    return day + '/' + month + '/' + year;
}

//#endregion
//#region AddModal
function AddExperience() {
    debugger;
    $.ajax({
        method: "GET",
        url: "/Admin/Experience/AddModal",
    }).done(function (result) {
        $("#ExperienceAddModalDiv").html(result);
        $("#ExperienceAddModal").modal('show');
    }).fail(function (error) {
        console.log(error);
    });
}
//#endregion
//#region Add
function sbtAddExperience() {
    var experienceAddData = {
        Title: $("#Title").val(),
        Description: $("#Description").val(),
        StartDate: $("#StartDate").val(),
        FinishDate: $("#FinishDate").val()
    };
    $.ajax({
        type: 'POST',
        url: "/Admin/Experience/AddExperience",
        data: { 'expAddData': JSON.stringify(experienceAddData) },
        dataType: "json",
    }).done(function (response) {
        if (response.data != null) {
            $('#ExperienceAddModal').modal('hide');
            Swal.fire({
                    icon: 'success',
                    title: 'Add successful',
                    confirmButtonText: 'Okey'
                }).then((rslt) => {
                    GetExperienceData();
                });
        } else {
            Swal.fire({
                icon: 'error',
                title: 'Add Failed',
                confirmButtonText: 'Okey'
            });
        }
    }).fail(function (error) {
        Swal.fire({
            icon: 'error',
            title: error,
            confirmButtonText: 'Okey'
        });
    });

}
//#endregion
//#region UpdateModal
function UpdateExperience(id) {
    $.ajax({
        method: "GET",
        url: "/Admin/Experience/UpdateModal/" + id,
    }).done(function (result) {
        $("#ExperienceUpdateModalDiv").html(result);
        $("#ExperienceUpdateModal").modal('show');
    }).fail(function (error) {
        console.log(error);
    });
}
//#endregion
//#region Update
function sbtUpdateExperience() {
    var experienceUpdateData = {
        Id : $("#Id").val(),
        Title: $("#Title").val(),
        Description: $("#Description").val(),
        StartDate: $("#StartDate").val(),
        FinishDate: $("#FinishDate").val()
    };

    $.ajax({
        type: 'POST',
        url: "/Admin/Experience/UpdateExperience",
        data: { 'expUpdateData': JSON.stringify(experienceUpdateData) },
        dataType: "json",
    }).done(function (response) {
        if (response.data != null) {
            $('#ExperienceUpdateModal').modal('hide');
            Swal.fire({
                icon: 'success',
                title: 'Update successful',
                confirmButtonText: 'Okey'
            }).then((rslt) => {
                GetExperienceData();
            });
        } else {
            Swal.fire({
                icon: 'error',
                title: 'Update Failed',
                confirmButtonText: 'Okey'
            });
        }
    }).fail(function (error) {
        Swal.fire({
            icon: 'error',
            title: error,
            confirmButtonText: 'Okey'
        });
    });
    
}
//#endregion
//#region Delete
function DeleteExperience(id) {
    Swal.fire({
        title: '',
        text: "Are you sure the selected experience will be deleted?",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes',
        cancelButtonText: 'Cancel'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                method: "POST",
                url: "/Admin/Experience/DeleteExperience/" + id,
                success: function (response) {
                    if (response.data != null) {
                        Swal.fire({
                            icon: 'success',
                            title: 'Deletion successful',
                            confirmButtonText: 'Okey'
                        }).then((rslt) => {
                            GetExperienceData();
                        });
                    } else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Deletion failed',
                            confirmButtonText: 'Okey'
                        })
                    }
                }
            });
        }
    });
}
//#endregion
//#region Ready
$(document).ready(function () {
    GetExperienceData();

});
//#endregion
