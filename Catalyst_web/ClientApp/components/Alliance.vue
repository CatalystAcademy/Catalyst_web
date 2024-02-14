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
                      <ul>
                        <li>{{translations.AllianceOneTextOne}}</li>
                        <li>{{translations.AllianceOneTextTwo}}</li>
                      </ul>
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
                      <ul>
                        <li>{{translations.AllianceTwoTextOne}}</li>
                        <li>{{translations.AllianceTwoTextTwo}}</li>
                      </ul>
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
                  <b-button block v-b-toggle.accordion-4 variant="info">{{translations.AllianceThreeLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-4" accordion="my-accordion-4" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <ul>
                        <li>{{translations.AllianceThreeTextOne}}</li>
                        <li>{{translations.AllianceThreeTextTwo}}</li>
                      </ul>
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
                  <b-button block v-b-toggle.accordion-3 variant="info">{{translations.AllianceFourLabel}}</b-button>
                </b-card-header>
                <b-collapse id="accordion-3" accordion="my-accordion-3" role="tabpanel">
                  <b-card-body>
                    <b-card-text>
                      <ul>
                        <li>{{translations.AllianceFourTextOne}}</li>
                        <li>{{translations.AllianceFourTextTwo}}</li>
                      </ul>
                    </b-card-text>
                  </b-card-body>
                </b-collapse>
              </b-card>
            </div>
          </div>
        </client-only>
      </div>


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
                    <ul class="level-list">
                      <li> {{ translations.CatalystsTextOne }}
                      </li>
                      <li>{{ translations.CatalystsTextTwo }}</li>
                      <li>{{ translations.CatalystsTextThree }}</li>
                    </ul>
                  </p>
                </div>
              </div>
                <div class="col-lg-6">
                <div class="hierarchy-level">
                  <div class="level-header">
                    <h2 class="level-title">{{ translations.FellowCatalysts }}</h2>
                    <div class="level-number">1</div>
                  </div>
                  <p class="level-description">
                    <ul class="level-list">
                      <li>
                        {{ translations.FellowCatalystsTextOne }}
                        </li>
                      <li>{{ translations.FellowCatalystsTextTwo }}</li>
                      <li>{{ translations.FellowCatalystsTextThree }}</li>
                     </ul>
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
  .custom-alliance {
    margin-bottom: 15px;
  }
  .alliance-hierarchy-custom {
      margin-top: 45px;
  }

  .alliance-one__single, .alliance-two__single {
    padding-top: 120px;
  }

  .alliance-one__single, .alliance-two__single {
    border-style: solid;
    border-width: 2px;
    border-color: #f1f1f1;
    background-color: white;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    text-align: center;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -ms-flex-direction: column;
    flex-direction: column;
    -webkit-box-shadow: none;
    box-shadow: none;
    -webkit-transition: -webkit-box-shadow .4s ease;
    transition: -webkit-box-shadow .4s ease;
    transition: box-shadow .4s ease;
    transition: box-shadow .4s ease, -webkit-box-shadow .4s ease;
    padding-top: 48px;
    padding-bottom: 48px;
  }

    .alliance-one__single:hover,
    .alliance-two__single:hover {
      -webkit-box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.05);
      box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.05);
    }

      .alliance-one__single:hover .contact-info-one__icon:before,
      .alliance-two__single:hover .contact-info-one__icon:before {
        left: 0;
      }

    .alliance-one__single .contact-info-one__icon {
    background-color: #2da397;
  }
    .alliance-two__single .contact-info-one__icon {
      background-color: #2da397;
    }

    .alliance-one__single .contact-info-one__icon::before {
      border-color: #2da397;
    }

    .alliance-two__single .contact-info-one__icon {
      background-color: #9f172f;
    }

      .alliance-two__single .contact-info-one__icon::before {
        border-color: #9f172f;
      }

  .btn-info {
    color: #fff;
    background-color: #2da397;
    border-color: #2da397;
  }

  .section-title {
    text-align: center;
    margin-bottom: 40px;
    font-size: 28px;
    color: #333;
  }

  .hierarchy-level {
    margin-bottom: 60px;
    padding: 20px;
    border-radius: 10px;
    background-color: #f9f9f9;
    box-shadow: 0px 5px 15px rgba(0, 0, 0, 0.1);
  }

  .level-header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 10px;
  }

  .level-title {
    font-size: 24px;
    color: #333;
  }

  .level-number {
    font-size: 36px;
    font-weight: bold;
    color: #007bff;
  }

  .level-description {
    font-size: 16px;
    line-height: 1.6;
    color: #666;
  }

  ul {
    padding-left: 20px; /* Adjust as needed */
  }

    .level-list li {
      margin-bottom: 18px;
    }
</style>
