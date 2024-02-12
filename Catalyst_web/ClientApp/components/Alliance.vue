<template>
  <section class="about-one ">
    <img src="/assets/images/circle-stripe.png" class="about-one__circle" alt="">
    <div class="container text-center">
      <div class="row custom-alliance">
        <div class="col-lg-12">
          <div class="alliance-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
            <div class="contact-info-one__icon">
              <i class="kipso-icon-manager"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.CAAlliance}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2">
<!--              <strong>{{translations.CAAlliance}}</strong>
-->              {{translations.CAAllianceText}}
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div><!-- /.col-lg-4 -->
      </div>
      <div class="row mb-5">
        <div class="col-lg-6">
          <b-button v-b-toggle.collapse-1 variant="primary">{{translations.AllianceOneLabel}}</b-button>
          <b-collapse id="collapse-1" class="mt-2">
            <b-card>
              <p class="card-text">
                <ul>
                  <li>{{translations.AllianceOneTextOne}}</li>
                  <li>{{translations.AllianceOneTextTwo}}</li>
                </ul>
              
              </p>
            </b-card>
          </b-collapse>
        </div>
        <div class="col-lg-6">
          <b-button v-b-toggle.collapse-2 variant="primary">{{translations.AllianceTwoLabel}}</b-button>
        <b-collapse id="collapse-2" class="mt-2">
          <b-card>
            <p class="card-text">
              <ul>
                <li>{{translations.AllianceTwoTextOne}}</li>
                <li>{{translations.AllianceTwoTextTwo}}</li>
              </ul>
            </p>
          </b-card>
        </b-collapse>
        </div>
        <div class="col-lg-6">
        <b-button v-b-toggle.collapse-3 variant="primary">Toggle Collapse</b-button>
        <b-collapse id="collapse-3" class="mt-2">
          <b-card>
            <p class="card-text">Collapse contents Here</p>
          </b-card>
        </b-collapse>
        </div>
        <div class="col-lg-6">
        <b-button v-b-toggle.collapse-4 variant="primary">Toggle Collapse</b-button>
        <b-collapse id="collapse-4" class="mt-2">
          <b-card>
            <p class="card-text">Collapse contents Here</p>
          </b-card>
        </b-collapse>
        </div>
      </div>
      <nuxt-link to="/apply" class="thm-btn about-one__btn">{{translations.StartLearningNowBtn}}</nuxt-link><!-- /.thm-btn -->
    </div><!-- /.container -->
</section>
</template>

<script>export default {
    name: "Alliance",
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    }
  }</script>

<style scoped>
  .custom-alliance {
    margin-bottom: 15px;
  }

  .alliance-one__single {
    padding-top: 120px;
  }

  .alliance-one__single {
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

    .alliance-one__single:hover {
      -webkit-box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.05);
      box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.05);
    }

      .alliance-one__single:hover .contact-info-one__icon:before {
        left: 0;
      }
</style>
