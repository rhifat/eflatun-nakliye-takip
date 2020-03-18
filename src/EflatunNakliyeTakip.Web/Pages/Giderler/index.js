$(function () {

    var l = abp.localization.getResource('EflatunNakliyeTakip');

    var createModal = new abp.ModalManager(abp.appPath + 'Giderler/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Giderler/EditModal');

    var dataTable = $('#GiderlerTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: true,
        autoWidth: false,        
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(eflatunNakliyeTakip.gider.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('GiderDeletionConfirmationMessage', data.record.name);
                                },
                                action: function (data) {
                                    eflatunNakliyeTakip.gider
                                        .delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('Başarıyla Silindi'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "islemTarihi" },
            { data: "vasita" },
            { data: "masraf" },
            { data: "aciklama" },
            { data: "miktar" }
            
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#YeniGiderButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});