<template>
  <section class="meeting-one">
      <div class="container">
          <div class="row">
              <div class="col-lg-6">
                  <div class="meeting-one__image">
                      <img src="/assets/images/custom/about_ca_1.jpg" alt="Awesome Image" />
                  </div><!-- /.meeting-one__image -->
              </div><!-- /.col-lg-6 -->
              <div class="col-lg-6">
                <div class="meeting-one__content">
                  <div class="block-title text-left">
                    <h2 class="block-title__title">{{translations.WhoIsCatalystText}}</h2><!-- /.block-title__title -->
                  </div><!-- /.block-title -->
                  <p class="meeting-one__block-text">
                    {{translations.CatalystDescription}}
                    <a href="/WhoIsCatalyst">{{translations.CatalystDescriptionButtonText}}</a>
                  </p>
                  <!-- /.meeting-one__block-text -->
                  <div class="meeting-one__box-wrap">
                    <div class="meeting-one__box">
                      <div class="meeting-one__bubble">{{translations.CatalystDialogueOne}}</div>
                      <!-- /.meeting-one__bubble -->
                      <img src="/assets/images/custom/soline_cut.jpg" alt="Awesome Image" />
                      <h3 class="meeting-one__title">Soulline Tadevosyan</h3><!-- /.meeting-one__title -->
                      <p class="meeting-one__text">{{translations.Student}}</p><!-- /.meeting-one__text -->
                    </div><!-- /.meeting-one__box -->
                    <div class="meeting-one__box">
                      <div class="meeting-one__bubble">{{translations.CatalystDialogueTwo}}</div><!-- /.meeting-one__bubble -->
                      <img src="/assets/images/custom/lyuda_cut.jpg" alt="Awesome Image" />
                      <h3 class="meeting-one__title">
                        Lyuda Zakaryan
                      </h3><!-- /.meeting-one__title -->
                      <p class="meeting-one__text">{{translations.Student}}</p><!-- /.meeting-one__text -->
                    </div><!-- /.meeting-one__box -->
                  </div><!-- /.meeting-one__box-wrap -->
                  <nuxt-link to="/apply" target="_blank" class="thm-btn about-one__btn mt-3">
                    {{translations.LearnMoreCatalystText}}
                  </nuxt-link>
                </div><!-- /.meeting-one__content -->
              </div><!-- /.col-lg-6 -->
          </div><!-- /.row -->
      </div><!-- /.container -->
  </section>
</template>

<script>
    export default {
    name: "Meeting",
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
