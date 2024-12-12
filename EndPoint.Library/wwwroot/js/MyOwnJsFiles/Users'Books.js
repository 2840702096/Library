function TheBookIsBack(id) {
    var PostData = {
        id: id
    };

    swal.fire({
        title: 'تحویل کتاب',
        text: "آیا کتاب بازگردانده شد؟",
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
                url: '/Users_Books/TheBookIsBack',
                data: PostData,
                success: function (data) {
                    if (data.isSuccess == 1) {
                        swal.fire({
                            title: data.title,
                            text: data.message,
                            icon: data.icon,
                            showCancelButton: false,
                            confirmButtonColor: '#3085d6',
                            cancelButtonColor: '#d33',
                            confirmButtonText: 'باشه'
                        }).then(function (isConfirm) {
                            location.replace("/Users_Books");
                        });
                    }
                    else {
                        if (data.isSuccess == 2) {
                            swal.fire({
                                title: data.title,
                                text: data.message,
                                icon: data.icon,
                                showCancelButton: true,
                                confirmButtonColor: '#3085d6',
                                cancelButtonColor: '#d33',
                                confirmButtonText: 'پرداخت شد',
                                cancelButtonText: 'خروج'
                            }).then((result) => {
                                if (result.value) {
                                    location.replace("/Users_Books/MakeTheFinePaid?id=" + id);
                                }
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
                },
                error: function (request, status, error) {
                    alert(request.responseText);
                }
            });
        }
    })
}

function ObserverMessageContext(id) {
    var PostDate = {
        id: id
    };

    $.ajax({
        url: "/Users_Books/ObserverMessageContext",
        type: "Get",
        data: PostDate,
        success: function (result) {
            $('#ModalBody').html(result);

            $('#ObserveOrEditMessageContextForm').data('validator', null);
            $.validator.unobtrusive.parse('#ObserveOrEditMessageContextForm');

            $('#ModalTitle').html('مشاهده پیام');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}