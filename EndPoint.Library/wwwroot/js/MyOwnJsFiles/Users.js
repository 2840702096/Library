function AddUser() {

    $.ajax({
        url: "/Users/AddUser",
        type: "Get",
        data: {},
        success: function (result) {
            $('#ModalBody').html(result);

            $('#AddOrEditUserForm').data('validator', null);
            $.validator.unobtrusive.parse('#AddOrEditUserForm');

            $('#ModalTitle').html('افزودن کاربر');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}

function EditUser(id) {
    var PostData = {
        editId: id
    };

    $.ajax({
        url: "/Users/AddUser",
        type: "Get",
        data: PostData,
        success: function (result) {
            $('#ModalBody').html(result);

            $('#AddOrEditUserForm').data('validator', null);
            $.validator.unobtrusive.parse('#AddOrEditUserForm');

            $('#ModalTitle').html('ویرایش کاربر');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}

function AddOrEditUserResult(data) {
    if (data.isSuccess == true) {
        swal.fire({
            title: data.title,
            text: data.message,
            icon: data.icon,
            showCancelButton: false,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'باشه'
        }).then(function (isConfirm) {
            location.replace("/Users");
        });
    }
    else {
        swal.fire({
            title: data.title,
            text: data.message,
            icon: data.icon,
            showCancelButton: false,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'باشه'
        });
    }
}

function DeleteUser(id) {
    var PostData = {
        id: id
    };

    swal.fire({
        title: 'حذف',
        text: "آیا از حذف مطمعا هستید؟",
        icon: 'info',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله ',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: 'Post',
                url: '/Users/DeleteUser',
                data: PostData,
                success: function (data) {
                    if (data.isSuccess == true) {
                        swal.fire({
                            title: data.title,
                            text: data.message,
                            icon: data.icon,
                            showCancelButton: false,
                            confirmButtonColor: '#3085d6',
                            cancelButtonColor: '#d33',
                            confirmButtonText: 'باشه'
                        }).then(function (isConfirm) {
                            location.replace("/Users");
                        });
                    }
                    else {

                        swal.fire({
                            title: data.title,
                            text: data.message,
                            icon: data.icon,
                            showCancelButton: false,
                            confirmButtonColor: '#3085d6',
                            cancelButtonColor: '#d33',
                            confirmButtonText: 'باشه'
                        });
                    }
                },
                error: function (request, status, error) {
                    alert(request.responseText);
                }

            });

        }
    })
}

function UserActivation(id) {
    var PostData = {
        id: id
    };

    swal.fire({
        title: 'فعال سازی',
        text: "آیا از فعال سازی مطمعا هستید؟",
        icon: 'info',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله ',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: 'Post',
                url: '/Users/Activation',
                data: PostData,
                success: function (data) {
                    if (data.isSuccess == true) {
                        swal.fire({
                            title: data.title,
                            text: data.message,
                            icon: data.icon,
                            showCancelButton: false,
                            confirmButtonColor: '#3085d6',
                            cancelButtonColor: '#d33',
                            confirmButtonText: 'باشه'
                        }).then(function (isConfirm) {
                            location.replace("/Users");
                        });
                    }
                    else {

                        swal.fire({
                            title: data.title,
                            text: data.message,
                            icon: data.icon,
                            showCancelButton: false,
                            confirmButtonColor: '#3085d6',
                            cancelButtonColor: '#d33',
                            confirmButtonText: 'باشه'
                        });
                    }
                },
                error: function (request, status, error) {
                    alert(request.responseText);
                }

            });

        }
    })
}

function MakingUserNoneActive(id) {
    var PostData = {
        id: id
    };

    swal.fire({
        title: 'غیرفعال سازی',
        text: "آیا از غیرفعال سازی مطمعا هستید؟",
        icon: 'info',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله ',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: 'Post',
                url: '/Users/Activation',
                data: PostData,
                success: function (data) {
                    if (data.isSuccess == true) {
                        swal.fire({
                            title: data.title,
                            text: data.message,
                            icon: data.icon,
                            showCancelButton: false,
                            confirmButtonColor: '#3085d6',
                            cancelButtonColor: '#d33',
                            confirmButtonText: 'باشه'
                        }).then(function (isConfirm) {
                            location.replace("/Users");
                        });
                    }
                    else {

                        swal.fire({
                            title: data.title,
                            text: data.message,
                            icon: data.icon,
                            showCancelButton: false,
                            confirmButtonColor: '#3085d6',
                            cancelButtonColor: '#d33',
                            confirmButtonText: 'باشه'
                        });
                    }
                },
                error: function (request, status, error) {
                    alert(request.responseText);
                }

            });

        }
    })
}