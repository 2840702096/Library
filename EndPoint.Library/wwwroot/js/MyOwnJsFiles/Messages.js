function ObserveOrEditMessageContext(id) {
    var PostDate = {
        id: id
    };

    $.ajax({
        url: "/Messages/ObserveOrEditMessageContext",
        type: "Get",
        data: PostDate,
        success: function (result) {
            $('#ModalBody').html(result);

            $('#ObserveOrEditMessageContextForm').data('validator', null);
            $.validator.unobtrusive.parse('#ObserveOrEditMessageContextForm');

            $('#ModalTitle').html('مشاهده و ویرایش پیام');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}

function ObserveOrEditMessageContextResult(data) {
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
            location.replace("/Messages");
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