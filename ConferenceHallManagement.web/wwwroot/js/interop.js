// Toastr Notification Functions
window.toastrSuccess = function (message, title) {
    toastr.success(message, title || 'Success');
};

window.toastrError = function (message, title) {
    toastr.error(message, title || 'Error');
};

window.toastrWarning = function (message, title) {
    toastr.warning(message, title || 'Warning');
};

window.toastrInfo = function (message, title) {
    toastr.info(message, title || 'Info');
};

// SweetAlert2 Confirmation Dialog
window.showConfirmDialog = function (title, text, icon, confirmButtonText, cancelButtonText) {
    return new Promise((resolve) => {
        Swal.fire({
            title: title || 'Are you sure?',
            text: text || "You won't be able to revert this!",
            icon: icon || 'warning',
            showCancelButton: true,
            confirmButtonColor: '#d33',
            cancelButtonColor: '#3085d6',
            confirmButtonText: confirmButtonText || 'Yes, delete it!',
            cancelButtonText: cancelButtonText || 'Cancel'
        }).then((result) => {
            resolve(result.isConfirmed);
        });
    });
};

// DataTable Initialization
window.initDataTable = function (tableId, options) {
    var table = $('#' + tableId);
    if ($.fn.DataTable.isDataTable(table)) {
        table.DataTable().destroy();
    }
    
    var defaultOptions = {
        responsive: true,
        autoWidth: false,
        pageLength: 10,
        lengthMenu: [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]],
        language: {
            search: "_INPUT_",
            searchPlaceholder: "Search...",
            lengthMenu: "Show _MENU_ entries",
            info: "Showing _START_ to _END_ of _TOTAL_ entries",
            paginate: {
                first: "First",
                last: "Last",
                next: "Next",
                previous: "Previous"
            }
        },
        order: [[0, 'desc']]
    };
    
    var finalOptions = $.extend({}, defaultOptions, options || {});
    return table.DataTable(finalOptions);
};

// Destroy DataTable
window.destroyDataTable = function (tableId) {
    var table = $('#' + tableId);
    if ($.fn.DataTable.isDataTable(table)) {
        table.DataTable().destroy();
    }
};

// Re-initialize DataTable after data update
window.reinitDataTable = function (tableId) {
    setTimeout(function () {
        window.destroyDataTable(tableId);
        window.initDataTable(tableId);
    }, 100);
};
