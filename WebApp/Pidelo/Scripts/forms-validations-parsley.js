var FormsValidationsParsley = {

	default: function () {
		var parsleyOptionsDefault = {
			successClass: 'has-success',
			errorClass: 'has-error',
			errorsWrapper: '<span class="help-block"></span>',
			errorTemplate: '<span></span>',
			classHandler : function( _el ) {
				return _el.$element.closest('.form-group');
			},
			errorsContainer: function (_el) {
				return _el.$element.closest('.inputer');
			},
		};
		$('.parsley-validate').parsley( parsleyOptionsDefault );
	},

	onlyIcon: function () {
		var parsleyOptionsIcon = {
			classHandler : function( _el ){
				return _el.$element.closest('.form-group');
			},
			errorsContainer: function (_el) {
				return _el.$element.closest('.inputer');
			}
		};

		$('.parsley-validate-icon').parsley( parsleyOptionsIcon );

		$('.parsley-validate-icon').parsley().subscribe('parsley:field:validate', function (field) {
			field.$element.closest('.form-group').addClass('has-feedback');
		});

		// when there is an error, display the tooltip with the error message
		$.listen('parsley:field:error', function(fieldInstance) {
			
			fieldInstance.$element.next('.form-control-feedback').remove();
			fieldInstance.$element.next('.ion-android-alert').remove();
			fieldInstance.$element.after('<span class="ion-android-alert tooltips form-control-feedback"></span>');

			// var messages = ParsleyUI.getErrorsMessages(fieldInstance);
			// fieldInstance.$element.tooltip('destroy');
			// fieldInstance.$element.tooltip({
			// 	animation: false,
			// 	container: 'body',
			// 	placement: 'right',
			// 	title: messages
			// });

	});

        // destroy tooltip when field is valid
        $.listen('parsley:field:success', function(fieldInstance) { 

        	fieldInstance.$element.next('.form-control-feedback').remove();
        	fieldInstance.$element.next('.parsley-errors-list').remove();
        	fieldInstance.$element.next('.ion-android-alert').remove();

        	fieldInstance.$element.after('<span class="ion-android-done form-control-feedback"></span>');    
        	// fieldInstance.$element.tooltip('destroy');

        });

    },

    init: function () {
    	this.default();
    	this.onlyIcon();
    	window.Parsley.setLocale('es');

		// $('.summernote-default').summernote(); // Summernote WYSIWYG Plugin
	}
}




