<template>
  <section class="about-one ">
    <img src="/assets/images/circle-stripe.png" class="about-one__circle" alt="">
    <div class="container text-center">
      <div class="row custom-about">
        <div class="col-lg-6">
          <div class="catalyst-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
            <div class="contact-info-one__icon">
              <i class="fas fa-handshake"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.CatalystLabelOne}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2 level-description">
              <span class="level-text"> {{translations.CatalystTextOne}} </span>
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div><!-- /.col-lg-4 -->

        <div class="col-lg-6">
          <div class="catalyst-one__single-cm wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
            <div class="contact-info-one__icon">
              <i class="fas fa-hand-holding-heart"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.CatalystLabelTwo}}</h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2 level-description">
              <span class="level-text"> {{translations.CatalystTextTwo}} </span>
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div>
        <div class="col-lg-6 custom-margin">
          <div class="catalyst-one__single-custom wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
            <div class="contact-info-one__icon">
              <i class="fas fa-chalkboard-teacher"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.CatalystLabelThree}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2 level-description">
              <span class="level-text"> {{translations.CatalystTextThree}} </span>
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div>
        <div class="col-lg-6 custom-margin">
          <div class="catalyst-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
            <div class="contact-info-one__icon">
              <i class="fas fa-briefcase"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.CatalystLabelFour}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2 level-description">
              <span class="level-text">{{translations.CatalystTextFour}} </span>
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div>

        <div class="col-lg-12 custom-margin">
          <div class="catalyst-one__single-pro wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
            <div class="contact-info-one__icon">
              <i class="fas fa-briefcase"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.CatalystLabelFive}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2 level-description">
              <span class="level-text">{{translations.CatalystTextFive}} </span>
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div>
      </div>

      <a href="/apply" target="_blank" class="thm-btn about-one__btn">{{translations.JoinCommunityBtnText}}</a><!-- /.thm-btn -->
    </div><!-- /.container -->
  </section>
</template>

<script>
  export default {
    name: "WhoIsCatalyst",
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    }
  };
</script>

<style scoped>
  .custom-margin {
    margin-top: 20px;
    margin-bottom: 15px;
  }

  .custom-about {
    margin-bottom: 15px;
  }


</style>
