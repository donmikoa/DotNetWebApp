$('.charity-alphabetical').change(function () {
	var n, t;
	$(this).val() != ''
		? ((n = $(this).val() == '#' ? '#\\' + this.value : '#' + this.value),
			$('.refresh-btn').show())
		: (n = '.letter-container:not(.letter-container-empty)'),
		(t = $(n)),
		$('.letter-container')
			.not(t)
			.hide(600),
		t.show(600);
});


function accreditation(obj) {
	if ($(obj).is(":checked")) {
		$(".notAccredited").hide();
	} else {
		$(".notAccredited").show();
    }
}


function sort(selector) {
    $(selector).children("li").sort(function (a, b) {
        var A = $(a).text().toUpperCase();
        var B = $(b).text().toUpperCase();
        return (A < B) ? -1 : (A > B) ? 1 : 0;
    }).appendTo(selector);
}  

window.onload = function () {
	var selItem = sessionStorage.getItem("SelItem");
	if (selItem == null) {
		selItem = 'select';
        Console.log(select);
    } else {
		$('.charity-type').val(selItem);
	}

    sort('#1');
    sort('#a');
    sort('#b');
    sort('#c');
    sort('#d');
    sort('#e');
    sort('#f');
    sort('#g');
    sort('#h');
    sort('#i');
    sort('#j');
    sort('#k');
    sort('#l');
    sort('#m');
    sort('#n');
    sort('#o');
    sort('#p');
    sort('#q');
    sort('#r');
    sort('#s');
    sort('#t');
    sort('#u');
    sort('#v');
    sort('#w');
    sort('#x');
    sort('#y');
    sort('#z');
}

$('.charity-type').change(function () {
	var selVal = $(this).val();
	sessionStorage.setItem("SelItem", selVal);
});

$('.directory-list').each(function () {
	if ($.trim($(this).text()) == '' && $(this).children().length == 0) {
		$(this).parent().hide();
		$(this).html('<li>No charities found for chosen filter.</li>');
	}
});

document.getElementById("refresh-btn").onclick = function () {
	$('.charity-type').val('select').trigger('change');
};


