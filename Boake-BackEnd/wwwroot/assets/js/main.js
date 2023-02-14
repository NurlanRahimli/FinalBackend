$(document).ready(function () {
    //Search
    $(document).on("keyup", "#search-input", function () {
        let inputVal = $(this).val().trim();
        $("#search-results li").slice(0).remove();
        $.ajax({
            method: "get",
            url: "shop/Search?search=" + inputVal,
            success: function (res) {
                $("#search-results").append(res);
            }
        })
    })

    // Responsive Menu2

    var cartResp = $('.cart-resp');
    cartResp.on('click', function (e) {
        e.preventDefault();
        $('.menu-cart').toggleClass('active')
        $('.overlay').toggleClass('overlay-color')
        $('.overlay').removeClass('active')

    });
    //Close-Button
    $('.shopping-cart-close').on('click', (e) => {
        e.preventDefault()
        $('.overlay').removeClass('overlay-color')
        $(".menu-cart").toggleClass('active')
    })

    var over = $('.overlay');
    over.on('click', function () {
        $('.overlay').removeClass('overlay-color')
        $('.menu-cart, .header-trigger').removeClass('active')
    })

    //Modal-fetch
    $(".productModalBtn").click(function (e) {
        e.preventDefault();
        let url = $(this).attr("href");

        fetch(url)
            .then(res => {
                return res.text();
            })
            .then(data => {
                $(".modal-body").html(data);
                $(".modal1").show();
            })
    })

    //Preloader
    $(window).on('load', function () {
        $('#hola').delay(500).fadeOut(500);
    });

    // Sticky Menu
    $(window).scroll(function () {
        if ($(window).scrollTop() >= 200) {
            $('nav').addClass('header');
            $('.nenujen').css('display', 'block')
        }
        else {
            $('nav').removeClass('header');
            $('.nenujen').css('display', 'none')
        }
    });

    

    // Scroll To Top 
    var scrollTop = $(".scrollToTop");
    $(window).on('scroll', function () {
        if ($(this).scrollTop() < 500) {
            scrollTop.removeClass("active");
        } else {
            scrollTop.addClass("active");
        }
    });


    //Click event to scroll to top
    $('.scrollToTop').on('click', function () {
        $('html, body').animate({
            scrollTop: 0
        }, 300);
        return false;
    });

    //Cart-Dropdown with click
    $("#iconCartI").click(() => {
        if ($(".cartDropDown").css("display") == "block") {
            $(".cartDropDown").css("display", "none");
        }
        else {
            $(".userDropDown").css("display", "none");
            $(".cartDropDown").css("display", "block");
        }
        var over = $('.overlay');
        over.on('click', function () {
            $('.overlay').removeClass('overlay-color')
            $('.menu, .header-trigger').removeClass('active')
        })
    })
    //Close-Dropdown
    $(".cart-close").click((e) => {
        e.preventDefault();
        if ($(".cartDropDown").css("display") == "block") {
            $(".cartDropDown").css("display", "none");
        }
    })

    //Sticky Cart-Dropdown 
    $("#iconCartISticky").click(() => {
        if ($(".cartDropDownSticky").css("display") == "block") {
            $(".cartDropDownSticky").css("display", "none");
        }
        else {
            $(".userDropDownSticky").css("display", "none");
            $(".cartDropDownSticky").css("display", "block");
        }
        var over = $('.overlay');
        over.on('click', function () {
            $('.overlay').removeClass('overlay-color')
            $('.menu, .header-trigger').removeClass('active')
        })
    })
    //Close-Dropdown
    $(".cart-close-sticky").click((e) => {
        e.preventDefault();
        if ($(".cartDropDownSticky").css("display") == "block") {
            $(".cartDropDownSticky").css("display", "none");
        }
    })



    //Setting-Dropdown with click
    $("#iconUserI").click(() => {
        if ($(".userDropDown").css("display") == "block") {
            $(".userDropDown").css("display", "none");
        }
        else {
            $(".cartDropdown").css("display", "none");
            $(".userDropDown").css("display", "block");
        }
        var over = $('.overlay');
        over.on('click', function () {
            $('.overlay').removeClass('overlay-color')
            $('.menu, .header-trigger').removeClass('active')
        })
    })

    //Sticky Setting-Dropdown with click
    $("#iconUserISticky").click(() => {
        if ($(".userDropDownSticky").css("display") == "block") {
            $(".userDropDownSticky").css("display", "none");
        }
        else {
            $(".cartDropdownSticky").css("display", "none");
            $(".userDropDownSticky").css("display", "block");
        }
        var over = $('.overlay');
        over.on('click', function () {
            $('.overlay').removeClass('overlay-color')
            $('.menu, .header-trigger').removeClass('active')
        })
    })


    // Responsive Menu
    var headerTrigger = $('.header-trigger');
    headerTrigger.on('click', function () {
        $('.menu,.header-trigger').toggleClass('active')
        $('.overlay').toggleClass('overlay-color')
        $('.overlay').removeClass('active')
    });

    var over = $('.overlay');
    over.on('click', function () {
        $('.overlay').removeClass('overlay-color')
        $('.menu, .header-trigger').removeClass('active')
    })


    




    /*--- Accordion ----*/
    $('.mobile-language-active').on('click', function (e) {
        e.preventDefault();
        $('.lang-dropdown-active').slideToggle(900);
    });
    $('.mobile-currency-active').on('click', function (e) {
        e.preventDefault();
        $('.curr-dropdown-active').slideToggle(900);
    });
    $('.mobile-account-active').on('click', function (e) {
        e.preventDefault();
        $('.account-dropdown-active').slideToggle(900);
    });


    //Slider
    $('.slider').slick({
        dots: true,
        appendDots: $('.slick-slider-dots'),
        prevArrow: $('.prev'),
        nextArrow: $('.next'),
        infinite: true,
        speed: 700,
        arrows: true,
        fade: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 1,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //Featured-Collections-Slider
    $('.featured-collections-slider').slick({
        dots: false,
        prevArrow: $('.prev-collection'),
        nextArrow: $('.next-collection'),
        infinite: true,
        speed: 700,
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 4,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //Featured-Tab-Slider
    $('.featured-tab-slider').slick({
        dots: false,
        prevArrow: $('.prev-tab'),
        nextArrow: $('.next-tab'),
        infinite: true,
        speed: 700,
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 4,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //New-Tab-Slider
    $('.new-tab-slider').slick({
        dots: false,
        prevArrow: $('.prev-new'),
        nextArrow: $('.next-new'),
        infinite: true,
        speed: 700,
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 4,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //Upsell-Tab-Slider
    $('.upsell-tab-slider').slick({
        dots: false,
        prevArrow: $('.prev-upsell'),
        nextArrow: $('.next-upsell'),
        infinite: true,
        speed: 700,
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 4,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //About-Testimonials Slider
    $('.about-testimonials-slider').slick({
        dots: true,
        appendDots: '.slick-dots-testimonial',
        infinite: true,
        speed: 700,
        arrows: false,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 1,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //Team-Slider
    $('.team-slider').slick({
        dots: false,
        prevArrow: $('.prev-team'),
        nextArrow: $('.next-team'),
        infinite: true,
        speed: 700,
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 4,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    })


    //Hot-Sale-Slider
    $('.hot-sale-slider').slick({
        dots: false,
        prevArrow: $('.prev-hot'),
        nextArrow: $('.next-hot'),
        infinite: true,
        speed: 700,
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 1,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //Best-Sale-Slider
    $('.best-sale-slider').slick({
        dots: false,
        prevArrow: $('.prev-best'),
        nextArrow: $('.next-best'),
        infinite: true,
        speed: 700,
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 1,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //Up-Sell-Slider
    $('.up-sell-slider').slick({
        dots: false,
        prevArrow: $('.prev-up'),
        nextArrow: $('.next-up'),
        infinite: true,
        speed: 700,
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 1,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //Latest-Blog
    $('.latest-blog-slider').slick({
        dots: false,
        infinite: true,
        speed: 700,
        arrows: false,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    })


    //Modal
    var url = $("#cartoonVideo").attr('src');

    $("#myModal").on('hide.bs.modal', function () {
        $("#cartoonVideo").attr('src', '');
    });

    $("#myModal").on('show.bs.modal', function () {
        $("#cartoonVideo").attr('src', url);
    });


    //Counter
    $('.minus').click(function () {
        var $input = $(this).parent().find('input');
        var count = parseInt($input.val()) - 1;
        count = count < 1 ? 1 : count;
        $input.val(count);
        $input.change();
        return false;
    });
    $('.plus').click(function () {
        var $input = $(this).parent().find('input');
        $input.val(parseInt($input.val()) + 1);
        $input.change();
        return false;
    });

    //Shop-Change-View
    let one = document.querySelector('one')
    let many = document.querySelector('many')
    $('.one-one').click(function (e) {
        e.preventDefault()
        $('.one').css('display', 'block')
        $('.many').css('display', 'none')
    })
    $('.many-many').click(function (e) {
        e.preventDefault()
        $('.many').css('display', 'block')
        $('.one').css('display', 'none')
    })

    //Checkout-Accordion
    $(".accordion-items").on("click", ".accordion-heading", function () {
        $(this).toggleClass("active-check").next().slideToggle();
        $(".accordion-content").not($(this).next()).slideUp(300);
        $(this).siblings().removeClass("active-check");
    });


})



//Shop-Accordion
var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function () {
        this.classList.toggle("active-acc");
        var panel = this.nextElementSibling;
        if (panel.style.maxHeight) {
            panel.style.maxHeight = null;
        } else {
            panel.style.maxHeight = panel.scrollHeight + "px";
        }
    });
}


///////////////////////////////////////////////////////////////////////////////
//Modal
const modalTrigger = document.querySelectorAll('[data-modal]'),
    modal = document.querySelector('.modal1'),
    modalCloseBtn = document.querySelector('[data-close]');

function openModal(e) {
    e.preventDefault()
    modal.classList.add('show');
    modal.classList.remove('hide');
    clearInterval(modalTimerId);
}

modalTrigger.forEach(btn => {
    btn.addEventListener('click', openModal);
});

function closeModal() {
    console.log("ss")
    modal.classList.add('hide');
    modal.classList.remove('show');
    document.body.style.overflow = '';
}


modalCloseBtn.addEventListener('click', closeModal);

modal.addEventListener('click', (e) => {
    if (e.target == modal) {
        closeModal()
    }
});

document.addEventListener('keydown', (e) => {
    if (e.code == 'Escape' && modal.classList.contains('show')) {
        closeModal()
    }
    // if (e.keyCode == 27) {
    //     closeModal()
    // }
});
//////////////////////////////////////////////////////////////////////////////////////////

//Timer
const deadline = '2024-11-15';

function getTimeRemaining(endtime) {
    let days, hours, minutes, seconds;
    const t = Date.parse(endtime) - Date.parse(new Date());

    if (t <= 0) {
        days = 0;
        hours = 0;
        minutes = 0;
        seconds = 0;
    }
    else {
        days = Math.floor(t / (1000 * 60 * 60 * 24)),
            hours = Math.floor((t / (1000 * 60 * 60) % 24)),
            minutes = Math.floor((t / 1000 / 60) % 60),
            seconds = Math.floor((t / 1000) % 60);
    }


    return {
        'total': t,
        'days': days,
        'hours': hours,
        'minutes': minutes,
        'seconds': seconds
    }
}

function getZero(num) {
    if (num >= 0 && num < 10) {
        return `0${num}`;
    } else {
        return num;
    }
}

function setClock(selector, endtime) {
    const timer = document.querySelector(selector);
    days = timer.querySelector('#days'),
        hours = timer.querySelector('#hours'),
        minutes = timer.querySelector('#minutes'),
        seconds = timer.querySelector('#seconds'),
        timeInterval = setInterval(updateClock, 1000);

    updateClock();


    function updateClock() {
        const t = getTimeRemaining(endtime);

        days.innerHTML = getZero(t.days);
        hours.innerHTML = getZero(t.hours);
        minutes.innerHTML = getZero(t.minutes);
        seconds.innerHTML = getZero(t.seconds);


        if (t.total <= 0) {
            clearInterval(timeInterval);
        }

    }
}
setClock('.timer', deadline);


//Tab
const tabs = document.querySelector(".wrapper");
const tabButton = document.querySelectorAll(".tab-button");
const contents = document.querySelectorAll(".content");

tabs.onclick = e => {
    const id = e.target.dataset.id;
    if (id) {
        tabButton.forEach(btn => {
            btn.classList.remove("active");
        });
        e.target.classList.add("active");

        contents.forEach(content => {
            content.classList.remove("active");
        });
        const element = document.getElementById(id);
        element.classList.add("active");
    }
}