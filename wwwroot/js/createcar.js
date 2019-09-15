function saveCar(){

    var make = $("txtMake").val();
    var model = $("#txtModel").val();
    var year = $("#txtYear").val();
    var description = $("#txtDesc").val();
    var color = $("#txtCol").val();
    var hp = $("#txtHP").val();
    var rentPrice = $("#txtPrice").val();
    var picture = $("#txtImg").val();
    var gasMilage = $("txtMPG").val();
    var passengers = $("txtPass").val();
    var cargoSpace = $("txtCargo").val();

    var newCar= {
        make: make,
        model: model,
        year: year,
        description: description,
        color: color,
        hp: hp,
        rentPrice: rentPrice,
        picture: picture,
        gasMilage: gasMilage,
        passengers: passengers,
        cargoSpace: cargoSpace,

    }

    console.log(newCar);

    $.ajax({
        url : '/Catalog/CreateCar',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(newCar),
        success: function(data){
            console.log("Response from Server", data);
            
        },
        error: function(error){
            console.error("Error on communication", error);
        }
    });

}

function init(){
    console.log("Init create car page");

    $("#btnSave").click(saveCar);
}





window.onload = init;