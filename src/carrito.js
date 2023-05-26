$(document).ready(function() {
  // Carrito de compras
  var cartItems = {};
  var total = 0;

  $('.add-to-cart-btn').click(function(e) {
    e.preventDefault();
    var productName = $(this).data('name');
    var productPrice = parseFloat($(this).data('price'));

    // Agregar el producto al carrito
    if (cartItems.hasOwnProperty(productName)) {
      cartItems[productName].quantity++;
    } else {
      cartItems[productName] = {
        name: productName,
        price: productPrice,
        quantity: 1
      };
    }

    // Actualizar el carrito
    updateCart();
  });

  function formatCartItem(product) {
    return product.name + ' x' + product.quantity;
  }

  function updateCart() {
    $('#cart-items').empty();
    total = 0;

    // Agregar los productos al carrito
    for (var key in cartItems) {
      if (cartItems.hasOwnProperty(key)) {
        var item = cartItems[key];
        $('#cart-items').append('<li>' + formatCartItem(item) + ' - $' + item.price.toFixed(2) + '</li>');
        total += item.price * item.quantity;
      }
    }

    // Actualizar el total
    $('#cart-total').text('$' + total.toFixed(2));
  }

  // Proceder al pago (checkout)
  $('#checkout-btn').click(function() {
    // Aquí puedes agregar la lógica para el proceso de pago
    alert('¡Gracias por tu compra!');
  });

  var cartToggle = document.getElementById('cart-toggle');
  var cartContainer = document.getElementById('cart-items');

  cartToggle.addEventListener('click', function() {
    if (cartContainer.style.display === 'none') {
      cartContainer.style.display = 'block';
    } else {
      cartContainer.style.display = 'none';
    }
  });
});

