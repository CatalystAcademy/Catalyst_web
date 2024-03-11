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
            <h2 class="contact-info-one__title">{{translations.CAAlliance}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2">
              {{translations.CAAllianceText}}
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
                  <b-button block v-b-toggle.accordion-1 variant="info">{{translations.AllianceOneLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-1" accordion="my-accordion-1" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                          <span class="level-text">{{translations.AllianceOneTextOne}}</span>
                        <span class="level-text">{{translations.AllianceOneTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-2 variant="info">{{translations.AllianceTwoLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-2" accordion="my-accordion-2" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                          <span class="level-text">{{translations.AllianceTwoTextOne}}</span>
                        <span class="level-text">{{translations.AllianceTwoTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-3 variant="info">{{translations.AllianceThreeLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-3" accordion="my-accordion-3" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                          <span class="level-text">{{translations.AllianceThreeTextOne}}</span>
                        <span class="level-text">{{translations.AllianceThreeTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-4 variant="info">{{translations.AllianceFourLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-4" accordion="my-accordion-4" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                          <span class="level-text">{{translations.AllianceFourTextOne}}</span>
                        <span class="level-text">{{translations.AllianceFourTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-5 variant="info">{{translations.AllianceFiveLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-5" accordion="my-accordion-5" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                          <span class="level-text">{{translations.AllianceFiveTextOne}}</span>
                        <span class="level-text">{{translations.AllianceFiveTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-6 variant="info">{{translations.AllianceSixLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-6" accordion="my-accordion-6" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                        <span class="level-text">{{translations.AllianceSixTextOne}}</span>
                        <span class="level-text">{{translations.AllianceSixTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-7 variant="info">{{translations.AllianceSevenLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-7" accordion="my-accordion-7" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                        <span class="level-text">{{translations.AllianceSevenTextOne}}</span>
                        <span class="level-text">{{translations.AllianceSevenTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-8 variant="info">{{translations.AllianceEightLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-8" accordion="my-accordion-8" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                        <span class="level-text">{{translations.AllianceEightTextOne}}</span>
                        <span class="level-text">{{translations.AllianceEightTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-9 variant="info">{{translations.AllianceNineLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-9" accordion="my-accordion-9" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                        <span class="level-text">{{translations.AllianceNineTextOne}}</span>
                        <span class="level-text">{{translations.AllianceNineTextTwo}}</span>
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
                  <b-button block v-b-toggle.accordion-10 variant="info">{{translations.AllianceTenLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-10" accordion="my-accordion-10" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <p class="level-description">
                        <span class="level-text">{{translations.AllianceTenTextOne}}</span><br />
                        <span class="level-text">{{translations.AllianceTenTextTwo}}</span><br />
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
    name: "Alliance",
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
