function AddBook() {

    $.ajax({
        url: "/Books/AddOrEditBook",
        type: "Get",
        data: {},
        success: function (result) {
            $('#ModalBody').html(result);

            $('#AddOrEditBookForm').data('validator', null);
            $.validator.unobtrusive.parse('#AddOrEditBookForm');

            $('#ModalTitle').html('افزودن کتاب');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}

function EditBook(id) {
    var PostData = {
        editId: id
    };

    $.ajax({
        url: "/Books/AddOrEditBook",
        type: "Get",
        data: PostData,
        success: function (result) {
            $('#ModalBody').html(result);

            $('#AddOrEditBookForm').data('validator', null);
            $.validator.unobtrusive.parse('#AddOrEditBookForm');

            $('#ModalTitle').html('ویرایش کتاب');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}

function AddOrEditBookResult(data) {
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
            location.replace("/Books");
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

function DeleteBook(id) {
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
                url: '/Books/DeleteBook',
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
                            location.replace("/Books");
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

function BookActivation(id) {
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
                url: '/Books/Activation',
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
                            location.replace("/Books");
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

function MakingBookNoneActive(id) {
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
                url: '/Books/Activation',
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
                            location.replace("/Books");
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