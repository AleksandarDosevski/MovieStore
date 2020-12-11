// Wait for the DOM to be ready
$(function () {
    // Initialize form validation on the movie create form.
    // It has the name attribute "moviecreate"
    $("form[name='moviecreate']").validate({
        success: "valid",
        // validation as we type data in the fields
        onkeyup: true,
        // add css error class
        errorClass: "error",
        // focus field when invalid
        focusInvalid: true,
        // highlight filds when error
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },
        // Specify validation rules
        rules: {
            // The key name on the left side is the name attribute
            // of an input field. Validation rules are defined
            // on the right side
            Title: {
                required: true,
                minlength: 2
            },
            YearOfRelease: "required",
            DirectorID: {
                required: true,
                min: 1
            },
            Price: {
                required: true,
                number: true,
                digits: true
            },
            MovieType: "required",
            Copies: {
                required: true,
                number: true,
                digits: true
            },
            Language: "required",
            Shipping: "required",
            Country: "required",
            Description: "required"
        },

        // Specify validation error messages
        messages: {
            Title: {
                required: "Please enter your firstname",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            YearOfRelease: "Please enter your lastname",
            CategoryID: {
                required: "Please choose category",
                min: "Please select one category from the dropdown"
            },
            DirectorID: {
                required: "Please choose director",
                min: "Please select one director from the dropdown"
            },
            Price: {
                required: "Please enter the price of the movie",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field"
            },
            Copies: "Please enter number of copies",
            Language: "Please enter movie language",
            Shipping: "Please enter shipping",
            Country: "Please enter country of origin",
            Description: "Please enter description"
        },

        // Make sure the form is submitted to the destination defined
        // in the "action" attribute of the form when valid
        submitHandler: function (form) {
            form.submit();
        }
    });
});