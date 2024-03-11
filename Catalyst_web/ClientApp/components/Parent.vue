<template>
  <section class="about-one ">
    <img src="/assets/images/circle-stripe.png" class="about-one__circle" alt="">
    <div class="container text-center">
      <div class="row custom-alliance">
        <div class="col-lg-12">
          <div class="alliance-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
            <div class="contact-info-one__icon">
              <i class="fas fa-handshake"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.ParentLabelOne}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2">
              {{translations.ParentTextOne}}
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div><!-- /.col-lg-4 -->
      </div>
      <div class="row mb-5">
        <client-only>
          <div class="col-lg-6">
            <div class="accordion" role="tablist">
              <b-card no-body class="mb-1">
                <b-card-header header-tag="header" class="p-1" role="tab">
                  <b-button block v-b-toggle.accordion-1 variant="info">{{translations.ParentLabelTwo}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-1" accordion="my-accordion-1" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                        <span class="level-text">{{translations.ParentTextTwo}}</span>
                        <ul>
                          <li>{{translations.ParentingSkills}}</li>
                          <li>{{translations.AcademicSupport}}</li>
                          <li>{{translations.SocialEmotional}}</li>
                          <li>{{translations.CareerReadiness}}</li>
                          <li>{{translations.TechnologyOnline}}</li>
                          <li>{{translations.HealthWellness}}</li>
                        </ul>
                        <span class="level-text">{{translations.ParentTextThree}}</span>
                      </p>
                    </b-card-text>
                  </b-card-body>
                </b-collapse>
              </b-card>
            </div>
          </div>
          <div class="col-lg-6">
            <div class="accordion" role="tablist">
              <b-card no-body class="mb-1">
                <b-card-header header-tag="header" class="p-1" role="tab">
                  <b-button block v-b-toggle.accordion-2 variant="info">{{translations.ParentLabelFour}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-2" accordion="my-accordion-2" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                        <span class="level-text">{{translations.ParentTextFour}}</span>
                        <span class="level-text">{{translations.ParentTextFourTwo}}</span>
                      </p>
                    </b-card-text>
                  </b-card-body>
                </b-collapse>
              </b-card>
            </div>
          </div>

        </client-only>
      </div>

      <nuxt-link to="/apply" target="_blank" class="thm-btn about-one__btn">
        {{translations.StartLearningNowBtn}}
      </nuxt-link><!-- /.thm-btn -->
    </div><!-- /.container -->
  </section>
</template>

<script>

  export default {
    name: "Parent",
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
