<template>
    <div>
      <div class="topbar-one">
          <div class="container">
              <div class="topbar-one__left">
                <a href="#">info@catalystsacademy.com</a>
                  <a href="#">+37441575714</a>
              </div><!-- /.topbar-one__left -->
              <div class="topbar-one__right">
                  <a href="#">Login</a>
                  <a href="#">Register</a>
              </div><!-- /.topbar-one__right -->
          </div><!-- /.container -->
      </div><!-- /.topbar-one -->
<header class="site-header site-header__header-one ">
          <nav class="navbar navbar-expand-lg navbar-light header-navigation stricky">
              <div class="container clearfix">
                  <!-- Brand and toggle get grouped for better mobile display -->
                  <div class="logo-box clearfix">
                      <a class="navbar-brand" href="/">
                          <img src="/assets/images/CA_Logo_4.png" class="main-logo" width="128" alt="Awesome Image" />
                      </a>
                      <div class="header__social">
                          <a href="#"><i class="fab fa-facebook-square"></i></a>
                          <a href="#"><i class="fab fa-instagram"></i></a>
                      </div><!-- /.header__social -->
                      <button class="menu-toggler" data-target=".main-navigation">
                          <span class="kipso-icon-menu"></span>
                      </button>
                  </div><!-- /.logo-box -->
                  <!-- Collect the nav links, forms, and other content for toggling -->
                  <div class="main-navigation">
                      <ul class=" navigation-box">
                          <li class="current">
                              <nuxt-link to="/">Home</nuxt-link>
                          </li>
                          <li>
                            <nuxt-link to="/about">About</nuxt-link>
                          </li>
                          <li>
                              <nuxt-link to="/courses">Courses</nuxt-link>
                          </li>
                          <li>
                              <nuxt-link to="/teachers">Teachers</nuxt-link>
                              <ul class="sub-menu">
                                  <li><nuxt-link to="/become-teacher">Become Teacher</nuxt-link></li>
                              </ul><!-- /.sub-menu -->
                          </li>
                          <li>
                              <nuxt-link to="/news">News</nuxt-link>
                          </li>
                          <li>
                              <nuxt-link to="/contact">Contact</nuxt-link>
                          </li>
                      </ul>
                  </div><!-- /.navbar-collapse -->
                  <div class="right-side-box">
                      <a class="header__search-btn search-popup__toggler" href="#"><i class="kipso-icon-magnifying-glass"></i>
                          <!-- /.kipso-icon-magnifying-glass --></a>
                  </div><!-- /.right-side-box -->
              </div>
              <!-- /.container -->
          </nav>
          <div class="site-header__decor">
              <div class="site-header__decor-row">
                  <div class="site-header__decor-single">
                      <div class="site-header__decor-inner-1"></div><!-- /.site-header__decor-inner -->
                  </div><!-- /.site-header__decor-single -->
                  <div class="site-header__decor-single">
                      <div class="site-header__decor-inner-2"></div><!-- /.site-header__decor-inner -->
                  </div><!-- /.site-header__decor-single -->
                  <div class="site-header__decor-single">
                      <div class="site-header__decor-inner-3"></div><!-- /.site-header__decor-inner -->
                  </div><!-- /.site-header__decor-single -->
              </div><!-- /.site-header__decor-row -->
          </div><!-- /.site-header__decor -->
      </header>
    </div>
</template>

<script>
    export default {
        name: "NavOne",
        mounted() {
          if ($(".main-navigation .navigation-box").length) {
            var subMenu = $(".main-navigation .sub-menu");
            subMenu
              .parent("li")
              .children("a")
              .append(function () {
                return '<button class="sub-nav-toggler"> <span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span> <span class="icon-bar"></span> <span class="icon-bar"></span> </button>';
              });
            var mainNavToggler = $(".header-navigation .menu-toggler");
            var subNavToggler = $(".main-navigation .sub-nav-toggler");
            mainNavToggler.on("click", function () {
              //alert()
              var Self = $(this);
              var menu = Self.data("target");
              $(menu).slideToggle();
              $(menu).toggleClass("showen");
              return false;
            });
            subNavToggler.on("click", function () {
              var Self = $(this);
              Self.parent().parent().children(".sub-menu").slideToggle();
              return false;
            });
          }
        },
    }
</script>

<style scoped>

</style>
