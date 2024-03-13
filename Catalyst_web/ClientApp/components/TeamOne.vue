<template>
  <section class="team-one team-one__become-teacher">
      <div class="container">
          <div class="block-title text-center">
            <h2 class="block-title__title"></h2><!-- /.block-title__title -->
          </div><!-- /.block-title -->
          <div class="row" v-if="teachers.length">
              <div class="col-xl-3 col-lg-6 col-md-6 col-sm-12" v-for="teacher in teachers" :key="teacher.id">
                  <div class="team-one__single">
                    <div class="team-one__image">
                      <img :src="'/assets/images/team/' + getFirstName(teacher.fullNameEng) + '_206.png'" alt="">
                    </div><!-- /.team-one__image -->
                      <div class="team-one__content">
                        <h2 class="team-one__name"><nuxt-link :to="`teachers/${teacher.id}`">{{teacher.fullNameEng}}</nuxt-link></h2>
                        <!-- /.team-one__name -->
                        <p class="team-one__designation">{{teacher.professionEng}}</p><!-- /.team-one__designation -->
<!--                        <p class="team-one__text">There are many varia of passages of lorem.</p>
-->                        <!-- /.team-one__text -->
                      </div><!-- /.team-one__content -->
                      <div class="team-one__social">
                        <a :href="teacher.link" target="_blank"><i class="fab fa-linkedin"></i></a>
                        <!--                          <a href="#"><i class="fab fa-facebook-square"></i></a>
                      <a href="#"><i class="fab fa-instagram"></i></a>-->
                      </div><!-- /.team-one__social -->
                  </div><!-- /.team-one__single -->
              </div><!-- /.col-lg-3 -->

          </div><!-- /.row -->
      </div><!-- /.container -->
  </section>
</template>

<script>
  import https from 'https';

    export default {
    name: "TeamOne",
    data() {
      return {
        teachers: [],
      }
    },
    methods: {
      getFirstName(fullName) {
        if (!fullName) return '';
        return fullName.split(' ')[0].toLowerCase();
      }
    },
    async fetch() { // Use fetch for component-level data fetching
      try {
        const response = await this.$axios.get('/api/Leaders');
        this.teachers = response.data;

      } catch (error) {
        console.error('Error fetching teachers or welcome message:', error);
        this.error = true;
      }
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    }
    }
</script>

<style scoped>

</style>
