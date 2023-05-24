
  $(document).ready(function() {
    // Carrito de compras
    var cartItems = [];
    var total = 0;

    $('.add-to-cart-btn').click(function(e) {
      e.preventDefault();
      var productName = $(this).data('name');
      var productPrice = parseFloat($(this).data('price'));

      // Agregar el producto al carrito
      cartItems.push({ name: productName, price: productPrice });

      // Actualizar el carrito
      updateCart();
    });

    function updateCart() {
      $('#cart-items').empty();
      total = 0;

      // Agregar los productos al carrito
      for (var i = 0; i < cartItems.length; i++) {
        var item = cartItems[i];
        $('#cart-items').append('<li>' + item.name + ' - $' + item.price.toFixed(2) + '</li>');
        total += item.price;
      }

      // Actualizar el total
      $('#cart-total').text('$' + total.toFixed(2));
    }

    // Proceder al pago (checkout)
    $('#checkout-btn').click(function() {
      // Aquí puedes agregar la lógica para el proceso de pago
      alert('¡Gracias por tu compra!');
    });
  });

  document.addEventListener('DOMContentLoaded', function() {
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
