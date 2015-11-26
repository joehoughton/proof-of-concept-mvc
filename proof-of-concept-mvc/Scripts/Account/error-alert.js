$("form").submit(function () {
  if (!$(this).valid()) {
    $('input').each(function (index, data) { // iterate through input fields
      if ($(this).hasClass('input-validation-error')) { // check for class, if error exists add bootstrap validation class
        $(this).parents('.form-group').addClass('has-error');
        $(this).addClass('text-danger');
        $('.has-error').removeClass('field-validation-error text-danger');
      } else {
        $(this).parents('.form-group').removeClass('has-error');
        $(this).removeClass('text-danger');
        $('.has-error').removeClass('field-validation-error text-danger');
      }
    });
  }
});

// login failure - invalid login attempt message
if ($(".validation-summary-errors")[0]) {
  var list = $("#error-message ul");
  $('#error-message').css('display', 'block'); // show error message
}

// get all form erros and add them to the error-message div
$("form").bind("invalid-form.validate", function (evt, validator) {
  $('#error-message').css('display', 'block'); // remove display none to make visible

  var list = $("#error-message ul");

  if (validator.errorList.length) {
    list.empty();

    var uniqueList = {};
    $.each(validator.errorList, function () {
      uniqueList[this.message] = this.message;
    });

    for (key in uniqueList) {
      $("<li />").html('<i class="fa fa-exclamation-triangle"></i> ' + uniqueList[key]).appendTo(list);
    }
  }
});