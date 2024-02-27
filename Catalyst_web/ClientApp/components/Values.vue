<template>
  <section class="faq-one">
    <div class="container">
      <div class="block-title text-center">
        <h2 class="block-title__title">
        </h2><!-- /.block-title__title -->
      <p class="about-one__text mt-5 mb-5">
      </p><!-- /.about-one__text -->
      </div><!-- /.block-title -->
      <div class="row no-gutters">
        <div class="col-lg-6">
          <div class="faq-one__single">
            <div class="faq-one__icon">
              <span><i class="fas fa-toolbox"></i></span>
            </div><!-- /.faq-one__icon -->
            <div class="faq-one__content">
              <h2 class="faq-one__title">{{translations.ValuesOneLabel}}</h2><!-- /.faq-one__title -->
              <p class="faq-one__text">
                {{translations.ValuesOne}}
              </p><!-- /.faq-one__text -->
            </div><!-- /.faq-one__content -->
          </div><!-- /.faq-one__single -->
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-6">
          <div class="faq-one__single">
            <div class="faq-one__icon">
              <span><i class="kipso-icon-human-resources"></i></span>
            </div><!-- /.faq-one__icon -->
            <div class="faq-one__content">
              <h2 class="faq-one__title">{{translations.ValuesTwoLabel}}</h2><!-- /.faq-one__title -->
              <p class="faq-one__text">
                {{translations.ValuesTwo}}
              </p><!-- /.faq-one__text -->
            </div><!-- /.faq-one__content -->
          </div><!-- /.faq-one__single -->
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-6">
          <div class="faq-one__single">
            <div class="faq-one__icon">
              <span><i class="kipso-icon-strategy"></i></span>
            </div><!-- /.faq-one__icon -->
            <div class="faq-one__content">
              <h2 class="faq-one__title">{{translations.ValuesThreeLabel}}</h2><!-- /.faq-one__title -->
              <p class="faq-one__text">
                {{translations.ValuesThree}}
              </p><!-- /.faq-one__text -->
            </div><!-- /.faq-one__content -->
          </div><!-- /.faq-one__single -->
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-6">
          <div class="faq-one__single">
            <div class="faq-one__icon">
              <span><i class="kipso-icon-targeting"></i></span>
            </div><!-- /.faq-one__icon -->
            <div class="faq-one__content">
              <h2 class="faq-one__title">{{translations.ValuesFourLabel}}</h2><!-- /.faq-one__title -->
              <p class="faq-one__text">
                {{translations.ValuesFour}}
              </p><!-- /.faq-one__text -->
            </div><!-- /.faq-one__content -->
          </div><!-- /.faq-one__single -->
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-6" style="padding-bottom: 0px; border-bottom: 0px none;">
          <div class="faq-one__single">
            <div class="faq-one__icon">
              <span><i class="kipso-icon-black-graduation-cap-tool-of-university-student-for-head"></i></span>
            </div><!-- /.faq-one__icon -->
            <div class="faq-one__content">
              <h2 class="faq-one__title">{{translations.ValuesFiveLabel}}</h2><!-- /.faq-one__title -->
              <p class="faq-one__text">
                {{translations.ValuesFive}}
              </p><!-- /.faq-one__text -->
            </div><!-- /.faq-one__content -->
          </div><!-- /.faq-one__single -->
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-6" style="padding-bottom: 0px; border-bottom: 0px none;">
          <div class="faq-one__single">
            <div class="faq-one__icon">
              <span><i class="fas fa-certificate"></i></span>
            </div><!-- /.faq-one__icon -->
            <div class="faq-one__content">
              <h2 class="faq-one__title">{{translations.ValuesSixLabel}}</h2><!-- /.faq-one__title -->
              <p class="faq-one__text">
                {{translations.ValuesSix}}
              </p><!-- /.faq-one__text -->
            </div><!-- /.faq-one__content -->
          </div><!-- /.faq-one__single -->
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-6" style="padding-bottom: 0px; border-bottom: 0px none;">
          <div class="faq-one__single">
            <div class="faq-one__icon">
              <span><i class="fas fa-chalkboard-teacher"></i></span>
            </div><!-- /.faq-one__icon -->
            <div class="faq-one__content">
              <h2 class="faq-one__title">{{translations.ValuesSevenLabel}}</h2><!-- /.faq-one__title -->
              <p class="faq-one__text">
                {{translations.ValuesSeven}}
              </p><!-- /.faq-one__text -->
            </div><!-- /.faq-one__content -->
          </div><!-- /.faq-one__single -->
        </div><!-- /.col-lg-6 -->
      </div><!-- /.row -->
    </div><!-- /.container -->
  </section>
</template>


<script>
  export default {
    name: "Values",
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
