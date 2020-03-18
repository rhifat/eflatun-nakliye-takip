$(function () {

    var l = abp.localization.getResource('EflatunNakliyeTakip');

    var createModal = new abp.ModalManager(abp.appPath + 'Gelirler/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Gelirler/EditModal');


    var dataTable = $('#GelirlerTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(eflatunNakliyeTakip.gelir.getList),
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
                                    return l('GelirDeletionConfirmationMessage', data.record.name);
                                },
                                action: function (data) {
                                    eflatunNakliyeTakip.gelir
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
            {
                data: "islemTarihi",
                type: 'date'
                

            },
            { data: "vasita" },
            { data: "yukCikisNoktasi" },
            { data: "yukVarisNoktasi" },
            { data: "yuklenenFirma" },
            { data: "goturulecekFirma" },
            { data: "yukTonaj" },
            { data: "vasitaKm" },
            { data: "miktar" }

        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#YeniGelirButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});