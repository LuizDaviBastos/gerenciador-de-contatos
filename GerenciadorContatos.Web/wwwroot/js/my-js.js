
$(document).ready(function () {

    $('.excluir-contato').click(function () {

        let id = $(this).attr('contato-id').toString();
        
        swal({
            title: "Tem certeza?",
            text: "Tem certeza que deseja deletar esse contato?",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {

                    //Requisição ajax ao controlador responsável pela exclusão de contatos
                    $.ajax({
                        method: 'POST',
                        url: `Contato/Excluir?id=${id}`,
                        success: function () {

                            swal("Poof! Contato excluido", {
                                icon: "success",
                            }).then(result => {

                                //dando reload na pagina para atualizar os contatos
                                location.reload();
                            });

                        },
                        error: function () {
                            swal("Oops! Houve um erro ao excluir o contato");
                        }
                    });
                    
                } else {
                    swal("Ufa! Seu contato foi salvo");
                }
            });
    });

    $('.close-alert').click(function () {    
        $(this).parent().fadeOut('5');
    });

});