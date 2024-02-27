<template>
  <section class="faq-one">
      <div class="container">
          <div class="row no-gutters">
              <div class="col-lg-6">
                  <div class="faq-one__single">
                      <div class="faq-one__icon">
                          <span>?</span>
                      </div><!-- /.faq-one__icon -->
                      <div class="faq-one__content">
                        <h2 class="faq-one__title">{{translations.FaqQOne}}</h2><!-- /.faq-one__title -->
                        <p class="faq-one__text">{{translations.FaqAOne}}</p><!-- /.faq-one__text -->
                      </div><!-- /.faq-one__content -->
                  </div><!-- /.faq-one__single -->
              </div><!-- /.col-lg-6 -->
              <div class="col-lg-6">
                  <div class="faq-one__single">
                      <div class="faq-one__icon">
                          <span>?</span>
                      </div><!-- /.faq-one__icon -->
                      <div class="faq-one__content">
                        <h2 class="faq-one__title">{{translations.FaqQTwo}}</h2><!-- /.faq-one__title -->
                        <p class="faq-one__text">{{translations.FaqATwo}}</p><!-- /.faq-one__text -->
                      </div><!-- /.faq-one__content -->
                  </div><!-- /.faq-one__single -->
              </div><!-- /.col-lg-6 -->
              <div class="col-lg-6">
                  <div class="faq-one__single">
                      <div class="faq-one__icon">
                          <span>?</span>
                      </div><!-- /.faq-one__icon -->
                      <div class="faq-one__content">
                        <h2 class="faq-one__title">{{translations.FaqQThree}}</h2><!-- /.faq-one__title -->
                        <p class="faq-one__text">{{translations.FaqAThree}}</p><!-- /.faq-one__text -->
                      </div><!-- /.faq-one__content -->
                  </div><!-- /.faq-one__single -->
              </div><!-- /.col-lg-6 -->
              <div class="col-lg-6">
                  <div class="faq-one__single">
                      <div class="faq-one__icon">
                          <span>?</span>
                      </div><!-- /.faq-one__icon -->
                      <div class="faq-one__content">
                        <h2 class="faq-one__title">{{translations.FaqQFour}}</h2><!-- /.faq-one__title -->
                        <p class="faq-one__text">{{translations.FaqAFour}}</p><!-- /.faq-one__text -->
                      </div><!-- /.faq-one__content -->
                  </div><!-- /.faq-one__single -->
              </div><!-- /.col-lg-6 -->
              <div class="col-lg-6" style="padding-bottom: 0px; border-bottom: 0px none;">
                  <div class="faq-one__single">
                      <div class="faq-one__icon">
                          <span>?</span>
                      </div><!-- /.faq-one__icon -->
                      <div class="faq-one__content">
                        <h2 class="faq-one__title">{{translations.FaqQFive}}</h2><!-- /.faq-one__title -->
                        <p class="faq-one__text">{{translations.FaqAFive}}</p><!-- /.faq-one__text -->
                      </div><!-- /.faq-one__content -->
                  </div><!-- /.faq-one__single -->
              </div><!-- /.col-lg-6 -->
              <div class="col-lg-6" style="padding-bottom: 0px; border-bottom: 0px none;">
                  <div class="faq-one__single">
                      <div class="faq-one__icon">
                          <span>?</span>
                      </div><!-- /.faq-one__icon -->
                      <div class="faq-one__content">
                        <h2 class="faq-one__title">{{translations.FaqQSeven}}</h2><!-- /.faq-one__title -->
                        <p class="faq-one__text">{{translations.FaqASeven}}</p><!-- /.faq-one__text -->
                      </div><!-- /.faq-one__content -->
                  </div><!-- /.faq-one__single -->
              </div><!-- /.col-lg-6 -->
              <div class="col-lg-6" style="padding-bottom: 0px; border-bottom: 0px none;">
                  <div class="faq-one__single">
                      <div class="faq-one__icon">
                          <span>?</span>
                      </div><!-- /.faq-one__icon -->
                      <div class="faq-one__content">
                        <h2 class="faq-one__title">{{translations.FaqQEight}}</h2><!-- /.faq-one__title -->
                        <p class="faq-one__text">{{translations.FaqAEight}}</p><!-- /.faq-one__text -->
                      </div><!-- /.faq-one__content -->
                  </div><!-- /.faq-one__single -->
              </div><!-- /.col-lg-6 -->
              <div class="col-lg-6" style="padding-bottom: 0px; border-bottom: 0px none;">
                  <div class="faq-one__single">
                      <div class="faq-one__icon">
                          <span>?</span>
                      </div><!-- /.faq-one__icon -->
                      <div class="faq-one__content">
                        <h2 class="faq-one__title">{{translations.FaqQEleven}}</h2><!-- /.faq-one__title -->
                        <p class="faq-one__text">{{translations.FaqAEleven}}</p><!-- /.faq-one__text -->
                      </div><!-- /.faq-one__content -->
                  </div><!-- /.faq-one__single -->
              </div><!-- /.col-lg-6 -->

          </div><!-- /.row -->
      </div><!-- /.container -->
  </section>
</template>

<script>
    export default {
    name: "Faq",
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

</style>
