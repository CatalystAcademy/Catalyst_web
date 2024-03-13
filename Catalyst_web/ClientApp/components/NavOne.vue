<template>
    <div>
      <div class="topbar-one">
          <div class="container">
              <div class="topbar-one__left">
                <a :href="'mailto:' + translations.CatalystEmail">{{translations.CatalystEmail}}</a>
                <a :href="'tel:' + translations.PhoneNumber">{{translations.CatalystPhone}}</a>
              </div>
  <!-- /.topbar-one__left -->
<!--              <div class="topbar-one__right">
                  <a href="#">Login</a>
                  <a href="#">Register</a>
              </div>-->
  <!-- /.topbar-one__right -->
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
                  <a href="https://www.facebook.com/catalystacademyarmenia?mibextid=ZbWKwL" target="_blank"><i class="fab fa-facebook-square"></i></a>
                  <a href="https://www.instagram.com/catalystsacademy?igsh=MTRwOWhuOHFtMzRpZg==" target="_blank"><i class="fab fa-instagram"></i></a>
                  <a href="https://www.linkedin.com/company/catalystsacademy/" target="_blank"><i class="fab fa-linkedin"></i></a>
                </div><!-- /.header__social -->
                <button class="menu-toggler" data-target=".main-navigation">
                  <span class="kipso-icon-menu"></span>
                </button>
              </div><!-- /.logo-box -->
              <!-- Language Dropdown -->


              <!-- Collect the nav links, forms, and other content for toggling -->
              <div class="main-navigation">
                <ul class=" navigation-box">
                  <!--                  <li class="current">
                      <nuxt-link to="/">{{translations.HomePage}}</nuxt-link>
                    </li>-->
                  <li>
                    <nuxt-link to="/about">About</nuxt-link>
                    <ul class="sub-menu">
                      <li><nuxt-link to="/about">Academy</nuxt-link></li>
                      <li><nuxt-link to="/WhoIsCatalyst">Catalyst</nuxt-link></li>
                      <li><nuxt-link to="/missionandvision">Mission & Vision</nuxt-link></li>
                      <li><nuxt-link to="/values">Values</nuxt-link></li>
                      <li><nuxt-link to="/leadership">Leadership</nuxt-link></li>
<!--                      <li><nuxt-link to="/teachers">Instructors</nuxt-link></li>
-->                      <li><nuxt-link to="/faq">FAQ's</nuxt-link></li>
                    </ul>
                  </li>
                  <li>
                    <nuxt-link to="/curriculums">Programs</nuxt-link>
                    <ul class="sub-menu">
                      <li><nuxt-link to="/curriculums">Curriculums</nuxt-link></li>
<!--                        <li><nuxt-link to="/courses">Courses</nuxt-link></li>
-->                    </ul>
                  </li>
                  <li>
                    <nuxt-link to="/parent">Parents</nuxt-link>
                  </li>
                  <li>
                    <nuxt-link to="/alliance">Alliance</nuxt-link>
                    <ul class="sub-menu">
                      <li><nuxt-link to="/alliance">About</nuxt-link></li>
                      <li><nuxt-link to="/hierarchy">Hierarchy</nuxt-link></li>
                    </ul>
                  </li>
                  <li>
                    <nuxt-link to="/news">News</nuxt-link>
                  </li>
                  <li>
                    <nuxt-link to="/blogs">Blogs</nuxt-link>
                  </li>
                  <li>
                    <nuxt-link to="/">Apply</nuxt-link>
                    <ul class="sub-menu">
                      <li><nuxt-link to="/apply" target="_blank">Apply Now</nuxt-link></li>
                      <li><nuxt-link to="/onSiteVisit">On-site Visit</nuxt-link></li>
                      <li><nuxt-link to="/contact">Contact Us</nuxt-link></li>
                    </ul>
                  </li>
                  <!--<li>-->
                    <!-- Language Dropdown -->
                    <!--<div class="dropdown">
                      <button class="btn dropdown-toggle language-dropdown-button"
                              type="button"
                              id="languageDropdown"
                              data-toggle="dropdown"
                              aria-haspopup="true"
                              aria-expanded="false">
                        <i class="fas fa-globe language-icon"></i>
                       
                        <i class="language-dropdown-button"></i>
                      </button>
                      <div class="dropdown-menu" aria-labelledby="languageDropdown">
                        <button @click="switchLanguage('en-US')" class="dropdown-item">
                          English
                        </button>
                        <button @click="switchLanguage('hy-AM')" class="dropdown-item">
                          Armenian
                        </button>-->
                        <!-- Add more language buttons and flags as needed -->
                      <!--</div>
                    </div>
                  </li>-->
                </ul>
              </div><!-- /.navbar-collapse -->
              <!--<div class="right-side-box">
                <a class="header__search-btn search-popup__toggler" href="#">
                  <i class="kipso-icon-magnifying-glass"></i>-->
                  <!-- /.kipso-icon-magnifying-glass -->
                <!--</a>
              </div>-->
  <!-- /.right-side-box -->
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
    data() {
      return {
        selectedLanguage: 'English', // Set the default language here
      };
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
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
    methods: {
      switchLanguage(language) {
        this.selectedLanguage = language === 'en-US' ? 'English' : 'Armenian';
        this.$i18n.setLocaleCookie(language)
        //this.$axios.get(`/api/SetLanguage?culture=${language}`);
        this.$store.commit('setLanguage', language);
        this.$i18n.setLocale(language);
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    },
}
</script>

<style scoped>
  .language-dropdown-button {
    margin-left: 10px;
    background-color: #ffffff;
    color: #14151a;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    line-height: 1.2;
    transition: 0.2s;
    will-change: transform;
    font-size: 1em;
    font-weight: 500;
    position: relative;
    display: inline-flex;
    justify-content: center;
    align-items: center;
    white-space: nowrap;
  }
  .language-icon {
    margin-right: 5px;
  }
  .language-dropdown-button:hover {
    box-shadow: 0 8px 16px rgba(0, 0, 0, 0.2); /* New shadow on hover */
    transform: translateY(-2px); /* Move the button slightly up on hover */
  }

  .language-flag {
    margin-right: 5px;
    width: 20px; /* Adjust the size as needed */
  }

  .dropdown-item {
    cursor: pointer;
  }

    .dropdown-item:hover {
      background-color: #fac975;
      color: #fff;
    }
</style>
