<template>
  <section class="about-one ">
    <img src="/assets/images/circle-stripe.png" class="about-one__circle" alt="">
    <div class="container text-center">
      
      <div class="row custom-mission-vision">
        <div class="col-lg-6">
          <div class="mission-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
            <div class="contact-info-one__icon">
              <i class="fas fa-seedling"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.OurVision}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2">
              {{translations.VisionOne}}
            <br />
            <br />
            <br />
               {{translations.VisionTwo}}
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-6 ">
          <div class="mission-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInUp;">
            <div class="contact-info-one__icon">
              <i class="fas fa-book-open"></i><!-- /.kipso-icon-manager -->
            </div><!-- /.contact-info-one__icon -->
            <h2 class="contact-info-one__title">{{translations.OurMission}} </h2><!-- /.contact-info-one__title -->
            <p class="contact-info-one__text m-2">
              {{translations.MissionOne}}
            <br />
            <br />
              {{translations.MissionTwo}}
            </p><!-- /.contact-info-one__text -->
          </div><!-- /.contact-info-one__single -->
        </div><!-- /.col-lg-4 -->
      </div>

      <nuxt-link to="/apply" target="_blank" class="thm-btn about-one__btn">{{translations.StartLearningNowBtn}}</nuxt-link><!-- /.thm-btn -->
    </div><!-- /.container -->
  </section>
</template>

<script>export default {
    name: "MissionandVision",
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
  .custom-mission-vision {
      margin-bottom: 15px;
  }

  .mission-one__single {
    padding-top: 120px;
  }

  .mission-one__single {
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

    .mission-one__single:hover {
      -webkit-box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.05);
      box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.05);
    }

      .mission-one__single:hover .contact-info-one__icon:before {
        left: 0;
      }
</style>
