function Guardar() {
    const Nombre = document.getElementById("nombre")
    const Email = document.getElementById("email")
    const Telefono = document.getElementById("telefono")
    const Mensaje = document.getElementById("mensaje")
    
    obj = {
        "Nombre": Nombre.value,            
        "Email": Email.value,
        "Tel": Telefono.value,
        "Mensaje": Mensaje.value
    }
    post(obj)
}
function post(obj) {
    $.ajax({
        type: "POST",
        dataType: "json",
        data: obj,
        url: "http://localhost:62020/api/Main/",
        success: function (data) {
            alert("Proceso Exitos...!!!")
        }
    })
}