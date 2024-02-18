<template>
  <section class="about-one ">
      <img src="/assets/images/circle-stripe.png" class="about-one__circle" alt="">
      <div class="container text-center">
        <div class="block-title text-center">
          <h2 class="block-title__title">
            {{translations.BeChampionOfChange}}
          </h2><!-- /.block-title__title -->
        </div><!-- /.block-title -->
        <div class="about-one__img">
          <div class="row">
            <div class="col-lg-6">
              <img src="/assets/images/about-2-1.jpg" alt="">
            </div><!-- /.col-lg-6 -->
            <div class="col-lg-6">
              <img src="/assets/images/about-2-2.jpg" alt="">
            </div><!-- /.col-lg-6 -->
          </div><!-- /.row -->
          <div class="about-one__review">
            <p class="about-one__review-count counter">88750</p><!-- /.about-one__review-count -->
            <div class="about-one__review-stars">
              <i class="fas fa-star"></i><!-- /.fa fa-star -->
              <i class="fas fa-star"></i><!-- /.fa fa-star -->
              <i class="fas fa-star"></i><!-- /.fa fa-star -->
              <i class="fas fa-star"></i><!-- /.fa fa-star -->
              <i class="fas fa-star"></i><!-- /.fa fa-star -->
            </div><!-- /.about-one__stars -->
            <p class="about-one__review-text">students loved us</p><!-- /.about-one__review-text -->
          </div><!-- /.about-one__review -->
        </div><!-- /.about-one__img -->

        <div class="row custom-about">
          <div class="col-lg-12">
            <div class="about-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
              <div class="contact-info-one__icon">
                <i class="fas fa-handshake"></i><!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">{{translations.CatalystAcademyText}} </h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text m-2">
                {{translations.CAMainDescription}}
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
        </div>

        <div class="row">
          <div class="col-lg-6">
            <div class="about-two__single-custom wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
              <div class="contact-info-one__icon">
                <i class="fas fa-hand-holding-heart"></i><!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title"></h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text m-2">
                {{translations.AboutAcademyOne}}
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div>
          <div class="col-lg-6">
            <div class="about-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
              <div class="contact-info-one__icon">
                <i class="fas fa-chalkboard-teacher"></i><!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title"> </h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text m-2">
                {{translations.AboutAcademyTwo}}
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div>
          <div class="col-lg-6 custom-margin">
            <div class="about-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
              <div class="contact-info-one__icon">
                <i class="fas fa-briefcase"></i><!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title"> </h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text m-2">
                {{translations.AboutAcademyThree}}
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div>
        </div>

        <a href="/apply" target="_blank" class="thm-btn about-one__btn">Start Learning Now</a><!-- /.thm-btn -->
      </div><!-- /.container -->
  </section>
</template>

<script>
    export default {
    name: "AboutOne",
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
  .custom-margin {
    margin-top: 20px;
    margin-bottom: 15px;
  }
  .custom-about {
    margin-bottom: 15px;
  }

  .about-one__single,
  .about-two__single-custom {
    padding-top: 120px;
  }

  .about-one__single,
  .about-two__single-custom {
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

    .about-one__single:hover,
    .about-two__single-custom:hover {
      -webkit-box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.05);
      box-shadow: 0px 10px 30px 0px rgba(0, 0, 0, 0.05);
    }

      .about-one__single:hover .contact-info-one__icon:before,
      .about-two__single-custom:hover .contact-info-one__icon:before {
        left: 0;
      }

      .about-one__single .contact-info-one__icon {
        background-color: #2da397;
      }

      .about-one__single .contact-info-one__icon::before {
        border-color: #2da397;
      }
    .about-two__single-custom .contact-info-one__icon {
      background-color: #db8e08;
    }

      .about-two__single-custom .contact-info-one__icon::before {
        border-color: #db8e08;
      }
</style>
