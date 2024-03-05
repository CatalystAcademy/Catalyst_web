<template>
  <section class="about-one ">
    <img src="/assets/images/circle-stripe.png" class="about-one__circle" alt="">
    <div class="container text-center">

      <div class="row custom-alliance">
        <div class="col-lg-12">
          <div class="alliance-two__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInUp;">
            <div class="contact-info-one__icon">
              <i class="fas fa-handshake"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h1 class="contact-info-one__title">{{translations.CAHierarchy}} </h1><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2">
              {{translations.CAHierarchyText}}
            </p><!-- /.contact-info-one__text -->

            <div class="row alliance-hierarchy-custom">
              <div class="col-lg-6">
                <div class="hierarchy-level">
                  <div class="level-header">
                    <h2 class="level-title">{{ translations.Catalysts }}</h2>
                    <div class="level-number">1</div>
                  </div>
                  <p class="level-description">
                    <span class="level-text">{{ translations.CatalystsTextOne }}</span><br>
                    <span class="level-text">{{ translations.CatalystsTextTwo }}</span><br>
                    <span class="level-text">{{ translations.CatalystsTextThree }}</span>
                  </p>
                </div>
              </div>
              <div class="col-lg-6">
                <div class="hierarchy-level">
                  <div class="level-header">
                    <h2 class="level-title">{{ translations.FellowCatalysts }}</h2>
                    <div class="level-number">2</div>
                  </div>
                  <p class="level-description">
                    <span class="level-text">{{ translations.FellowCatalystsTextOne }}</span><br>
                    <span class="level-text">{{ translations.FellowCatalystsTextTwo }}</span><br>
                    <span class="level-text">{{ translations.FellowCatalystsTextThree }}</span><br>
                  </p>
                </div>
              </div>
              <div class="col-lg-6">
                <div class="hierarchy-level">
                  <div class="level-header">
                    <h2 class="level-title">{{ translations.CaptainCatalysts }}</h2>
                    <div class="level-number">3</div>
                  </div>
                  <p class="level-description">
                    <span class="level-text">{{ translations.CaptainCatalystsTextOne }}</span><br>
                    <span class="level-text">{{ translations.CaptainCatalystsTextTwo }}</span><br>
                    <span class="level-text">{{ translations.CaptainCatalystsTextThree }}</span><br>
                  </p>
                </div>
              </div>
              <div class="col-lg-6">
                <div class="hierarchy-level">
                  <div class="level-header">
                    <h2 class="level-title">{{ translations.LeadCatalysts }}</h2>
                    <div class="level-number">4</div>
                  </div>
                  <p class="level-description">
                    <span class="level-text">{{ translations.LeadCatalystsTextOne }}</span><br>
                    <span class="level-text">{{ translations.LeadCatalystsTextTwo }}</span><br>
                    <span class="level-text">{{ translations.LeadCatalystsTextThree }}</span><br>
                  </p>
                </div>
              </div>
              <div class="col-lg-6">
                <div class="hierarchy-level">
                  <div class="level-header">
                    <h2 class="level-title">{{ translations.SeniorCatalysts }}</h2>
                    <div class="level-number">5</div>
                  </div>
                  <p class="level-description">
                    <span class="level-text">{{ translations.SeniorCatalystsTextOne }}</span><br>
                    <span class="level-text">{{ translations.SeniorCatalystsTextTwo }}</span><br>
                    <span class="level-text">{{ translations.SeniorCatalystsTextThree }}</span><br>
                  </p>
                </div>
              </div>
              <div class="col-lg-6">
                <div class="hierarchy-level">
                  <div class="level-header">
                    <h2 class="level-title">{{ translations.ChiefVisionaryCatalyst }}</h2>
                    <div class="level-number">6</div>
                  </div>
                  <p class="level-description">
                    <span class="level-text">{{ translations.ChiefVisionaryCatalystTextOne }}</span><br>
                    <span class="level-text">{{ translations.ChiefVisionaryCatalystTextTwo }}</span><br>
                    <span class="level-text">{{ translations.ChiefVisionaryCatalystTextThree }}</span><br>
                  </p>
                </div>
              </div>
            </div>

          </div><!-- /.contact-info-one__single -->
        </div><!-- /.col-lg-4 -->
      </div>

      <nuxt-link to="/apply" target="_blank" class="thm-btn about-one__btn">
        {{translations.StartLearningNowBtn}}
      </nuxt-link><!-- /.thm-btn -->
    </div><!-- /.container -->
  </section>
</template>
<script>
  export default {
    name: "Hierarchy",
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
