
function getCatalogFromServer(){

    $.ajax({
        url : '/Catalog/GetCatalog',
        type: 'GET',
        success: function(data){
            console.log("Response from Server", data);
            displayCatalog(data);
        },
        error: function(error){
            console.error("Error on communication", error);
        }
    });

}

function displayCatalog(list) {

    for (var i = 0; i < list.length; i++) {
        var car = list[i];

        var carContainer = $("#carlist");
        var carTemplate = 
        `
         <div class="card mb-3" style="max-width: 540px;">
         <div class="row no-gutters">
          <div class="col-md-7">
            <img src="${car.picture}" class="card-img" alt="...">
          </div>
          <div class="col-md-5">
            <div class="card-body">
              <h5 class="card-title">${car.make} ${car.model}</h5>
              <p class="card-text">${car.description}</p>
              <p class="card-text"><small class="text-muted">Cargo:${car.cargoSpace} HP:${car.hp}</small></p>
              <p class="card-text"><span class="price">$ ${car.rentPrice}</span>
               <button class="btn btn-primary float-right" onlcick="rent(${card.id})">Rent this car</button>
               </p>
            </div>
          </div>
         </div>
       </div>
      `;
        carContainer.append(carTemplate);

    }
}

function init(){
    console.log("initialize Catalog");

    getCatalogFromServer();
}

window.onload = init;