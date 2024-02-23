<template>
  <section class="cta-four">
              <img src="/assets/images/circle-stripe-1.png" class="cta-four__stripe" alt="">
              <img src="/assets/images/line-stripe-1.png" class="cta-four__line" alt="">
              <div class="container text-center">
                  <div class="block-title">
                    <h2 class="block-title__title">
                      {{translations.WeHaveBestTeachers}} <br>
                      {{translations.InEverySubject}}
                    </h2><!-- /.block-title__title -->
                  </div><!-- /.block-title -->
                  <!--<p class="cta-four__text">Lorem ipsum gravida nibh vel velit auctor aliquetnean sollicitudin, lorem quis
                      bibendum auci elit <br> consequat is simply free text available in the psutis sem nibh id eis sed odio sit
                      amet.</p>--><!-- /.cta-four__text -->
              </div><!-- /.container text-center -->
          </section>
</template>

<script>
    export default {
    name: "CallToActionFour",
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
  .cta-four {
      margin-top: 400px;
  }
</style>
