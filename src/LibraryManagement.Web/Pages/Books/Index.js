$(function () {
    var l = abp.localization.getResource('LibraryManagement');
    var createModal = new abp.ModalManager(abp.appPath + 'Books/CreateBook');
    var editModal = new abp.ModalManager(abp.appPath + 'Books/EditBook');

    var dataTable = $('#BooksTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(libraryManagement.services.book.getList),
            columnDefs: [
                {
                    title: l('Action'),
                    rowAction: {
                        items: [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id })
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('AreYouSureToDelete', data.record.name);
                                },
                                action: function (data) {
                                    libraryManagement.services.book
                                        .delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax().reload();
                                        });
                                }
                            }
                        ]
                    }
                },
                {
                    title: l('Title'),
                    data: "title"
                },
                {
                    title: l('Genre'),
                    data: "genre",
                    render: function (data) {
                        return l('Enum:BookGenre.' + data);
                    }
                },
                {
                    title: l('PublishDate'),
                    data: "publishDate",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: l('Price'),
                    data: "price"
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
    
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });
    
    editModal.onResult(function () {
        dataTable.ajax.reload();
    })
    
    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
