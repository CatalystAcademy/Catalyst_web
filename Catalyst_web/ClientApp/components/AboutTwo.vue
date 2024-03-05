<template>
  <section class="about-two">
    <div class="container">
      <div class="row">
        <div class="col-xl-6">
          <div class="about-two__content">
            <div class="block-title text-left">
              <h2 class="block-title__title">{{translations.WelcomeMessage}}</h2><!-- /.block-title__title -->
            </div><!-- /.block-title -->
            <p class="about-two__text">{{translations.CAMainDescription}}</p><!-- /.about-two__text -->
            <div class="about-two__single-wrap">
              <div class="about-two__single">
                <div class="about-two__single-icon">
                  <i class="kipso-icon-professor"></i><!-- /.kipso-icon-professor -->
                </div><!-- /.about-two__single-icon -->
                <div class="about-two__single-content">
                  <p class="about-two__single-text">
                    {{translations.StartLearningText}}
                  </p><!-- /.about-two__single-text -->
                </div><!-- /.about-two__single-content -->
              </div><!-- /.about-two__single -->
              <div class="about-two__single">
                <div class="about-two__single-icon">
                  <i class="kipso-icon-knowledge"></i><!-- /.kipso-icon-professor -->
                </div><!-- /.about-two__single-icon -->
                <div class="about-two__single-content">
                  <p class="about-two__single-text">
                    {{translations.EnhanceSkillsText}}
                  </p><!-- /.about-two__single-text -->
                </div><!-- /.about-two__single-content -->
              </div><!-- /.about-two__single -->
            </div><!-- /.about-two__single-wrap -->
            <a href="#" class="thm-btn">{{translations.LearnMore}}</a><!-- /.thm-btn -->
          </div><!-- /.about-two__content -->
        </div><!-- /.col-lg-6 -->
        <div class="col-xl-6 d-flex justify-content-xl-end justify-content-sm-center">
          <div class="about-two__image">
            <span class="about-two__image-dots"></span><!-- /.about-two__image-dots -->
            <img src="/assets/images/custom/about_edited.jpg" alt="">
            <div class="about-two__count">
              <div class="about-two__count-text">
                {{translations.TrustedByText}}
                <span class="counter">2570</span>
              </div><!-- /.about-two__count-text -->
            </div><!-- /.about-two__count -->
          </div><!-- /.about-two__image -->
        </div><!-- /.col-lg-6 -->
      </div><!-- /.row -->
    </div><!-- /.container -->


  </section>
</template>

<script>
    export default {
    name: "AboutTwo",
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    }
    }
</script>

<style scoped>
  .about-two__image:after {
    height: 80% !important;
    left: -13px !important;
  }
</style>
